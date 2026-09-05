(function () {
    const bell = document.getElementById('notifBell');
    if (!bell) return; // header didn't render the bell => user isn't authenticated

    const badge = document.getElementById('notifBadge');
    const list = document.getElementById('notifList');
    const markAllBtn = document.getElementById('notifMarkAllRead');
    let listLoaded = false;

    function headers(extra) {
        const token = document.querySelector('input[name="__RequestVerificationToken"]')?.value;
        const h = { 'Accept': 'application/json', ...(extra || {}) };
        if (token) h['RequestVerificationToken'] = token;
        return h;
    }

    function setBadge(count) {
        if (count > 0) {
            badge.textContent = count > 99 ? '99+' : count;
            badge.classList.remove('d-none');
        } else {
            badge.classList.add('d-none');
        }
    }

    function timeAgo(dateStr) {
        const mins = Math.floor((Date.now() - new Date(dateStr).getTime()) / 60000);
        if (mins < 1) return 'just now';
        if (mins < 60) return mins + 'm ago';
        const hours = Math.floor(mins / 60);
        if (hours < 24) return hours + 'h ago';
        return Math.floor(hours / 24) + 'd ago';
    }

    function notifItemHtml(n) {
        return `
            <a href="#" class="notif-item ${n.isRead ? '' : 'unread'}" data-id="${n.id}">
                <div class="notif-title">${n.title}</div>
                <div class="notif-msg">${n.msg}</div>
                <div class="notif-time">${timeAgo(n.createdAt)}</div>
            </a>`;
    }

    async function refreshUnreadCount() {
        try {
            const res = await fetch('/api/notifications/unread-count', { headers: headers() });
            const result = await res.json();
            setBadge(result.data || 0);
        } catch (e) { /* silent */ }
    }

    async function loadList() {
        try {
            const res = await fetch('/api/notifications', { headers: headers() });
            const result = await res.json();
            const items = result.data || [];
            list.innerHTML = items.length
                ? items.slice(0, 15).map(notifItemHtml).join('')
                : '<div class="text-center text-muted small py-4">No notifications yet.</div>';
        } catch (e) {
            list.innerHTML = '<div class="text-center text-muted small py-4">Failed to load notifications.</div>';
        }
    }

    list.addEventListener('click', async function (e) {
        const item = e.target.closest('.notif-item');
        if (!item) return;
        e.preventDefault();
        if (item.classList.contains('unread')) {
            item.classList.remove('unread');
            try {
                await fetch(`/api/notifications/${item.dataset.id}/read`, { method: 'PUT', headers: headers() });
                refreshUnreadCount();
            } catch (e) { /* handled */ }
        }
    });

    markAllBtn.addEventListener('click', async function () {
        try {
            await fetch('/api/notifications/read-all', { method: 'PUT', headers: headers() });
            list.querySelectorAll('.notif-item.unread').forEach(el => el.classList.remove('unread'));
            setBadge(0);
        } catch (e) { /* handled */ }
    });

    bell.closest('.dropdown').addEventListener('shown.bs.dropdown', function () {
        if (!listLoaded) { listLoaded = true; loadList(); }
    });

    refreshUnreadCount();

    // Real-time push via SignalR
    if (typeof signalR !== 'undefined') {
        const connection = new signalR.HubConnectionBuilder()
            .withUrl('/hubs/notifications')
            .withAutomaticReconnect()
            .build();

        connection.on('ReceiveNotification', function (notification) {
            setBadge((parseInt(badge.textContent, 10) || 0) + 1);
            if (listLoaded) {
                list.insertAdjacentHTML('afterbegin', notifItemHtml({ ...notification, isRead: false }));
            }

            const toastFn = notification.type === 'Alert' ? 'warning'
                : notification.type === 'Promotion' ? 'success'
                : 'info';
            if (typeof toastr !== 'undefined') toastr[toastFn](notification.msg, notification.title);
        });

        connection.start().catch(err => console.error('SignalR connection failed:', err));
    }
})();