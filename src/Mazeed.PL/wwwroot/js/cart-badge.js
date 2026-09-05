(function () {
    const badge = document.getElementById('cartBadge');
    if (!badge) return; // header didn't render the cart icon => user isn't authenticated

    fetch('/api/cart', { headers: { 'Accept': 'application/json' } })
        .then(res => res.ok ? res.json() : null)
        .then(data => {
            const count = data?.data?.totalItemsCount || 0;
            if (count > 0) {
                badge.textContent = count > 99 ? '99+' : count;
                badge.classList.remove('d-none');
            }
        })
        .catch(() => { /* silent — badge just stays hidden */ });
})();