// // Put this in site.js or global _Layout script block
// document.addEventListener("DOMContentLoaded", function () {
//     // 1. Accordion Icon Toggles
//     document.querySelectorAll('.collapse').forEach(collapseEl => {
//         collapseEl.addEventListener('show.bs.collapse', function () {
//             const icon = this.previousElementSibling.querySelector('.toggle-icon');
//             if (icon) icon.textContent = '-';
//         });
//         collapseEl.addEventListener('hide.bs.collapse', function () {
//             const icon = this.previousElementSibling.querySelector('.toggle-icon');
//             if (icon) icon.textContent = '+';
//         });
//     });

//     // 2. Price Handle Constraint Tracking
//     const minSlider = document.getElementById('minPriceSlider');
//     const maxSlider = document.getElementById('maxPriceSlider');
//     if (minSlider && maxSlider) {
//         const updatePrice = () => {
//             let minVal = parseInt(minSlider.value);
//             let maxVal = parseInt(maxSlider.value);
//             if (minVal > maxVal) { minSlider.value = maxVal; minVal = maxVal; }
//             document.getElementById('minPriceVal').textContent = minVal;
//             document.getElementById('maxPriceVal').textContent = maxVal;
//         };
//         minSlider.addEventListener('input', updatePrice);
//         maxSlider.addEventListener('input', updatePrice);
//     }

//     // 3. Reusable Selection Bundlers
//     function setupSelectAll(masterId, childClass) {
//         const master = document.getElementById(masterId);
//         if (!master) return;
//         master.addEventListener('change', function () {
//             document.querySelectorAll('.' + childClass).forEach(cb => cb.checked = this.checked);
//         });
//         document.querySelectorAll('.' + childClass).forEach(cb => {
//             cb.addEventListener('change', function () {
//                 const all = document.querySelectorAll('.' + childClass);
//                 const checked = document.querySelectorAll('.' + childClass + ':checked');
//                 master.checked = (all.length === checked.length);
//                 master.indeterminate = (checked.length > 0 && checked.length < all.length);
//             });
//         });
//     }
//     setupSelectAll('allCategories', 'cat-checkbox');
//     setupSelectAll('allBrands', 'brand-checkbox');
// });
(() => {
	const themeKey = "mazeed-theme";
	const root = document.documentElement;

	function getStoredTheme() {
		try {
			return localStorage.getItem(themeKey);
		} catch {
			return null;
		}
	}

	function storeTheme(theme) {
		try {
			localStorage.setItem(themeKey, theme);
		} catch {
		}
	}

	function setTheme(theme) {
		const isDark = theme === "dark";
		root.dataset.theme = isDark ? "dark" : "light";
		storeTheme(isDark ? "dark" : "light");

		document.querySelectorAll("[data-theme-toggle]").forEach(toggle => {
			const icon = toggle.querySelector("[data-theme-icon]");
			const label = toggle.querySelector("[data-theme-label]");
			toggle.setAttribute("aria-label", isDark ? "Switch to light mode" : "Switch to dark mode");
			if (icon) icon.className = icon.classList.contains("bi")
				? (isDark ? "bi bi-sun-fill" : "bi bi-moon-fill")
				: (isDark ? "fa-solid fa-sun" : "fa-solid fa-moon");
			if (label) label.textContent = isDark ? "Light mode" : "Dark mode";
		});
		document.dispatchEvent(new CustomEvent("mazeed-theme-changed", { detail: { isDark } }));
	}

	function initializeTheme() {
		setTheme(getStoredTheme() === "dark" ? "dark" : "light");
	}

	if (document.readyState === "loading") {
		document.addEventListener("DOMContentLoaded", initializeTheme, { once: true });
	} else {
		initializeTheme();
	}

	document.addEventListener("click", event => {
		const toggle = event.target.closest("[data-theme-toggle]");
		if (toggle) {
			setTheme(root.dataset.theme === "dark" ? "light" : "dark");
		}
	});
})();
