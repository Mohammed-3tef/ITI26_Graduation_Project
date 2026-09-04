// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

(() => {
	const themeKey = "mazeed-theme";
	const root = document.documentElement;

	function setTheme(theme) {
		const isDark = theme === "dark";
		root.dataset.theme = isDark ? "dark" : "light";
		localStorage.setItem(themeKey, isDark ? "dark" : "light");

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

	document.addEventListener("DOMContentLoaded", () => {
		setTheme(localStorage.getItem(themeKey) === "dark" ? "dark" : "light");

		document.querySelectorAll("[data-theme-toggle]").forEach(toggle => {
			toggle.addEventListener("click", () => {
				setTheme(root.dataset.theme === "dark" ? "light" : "dark");
			});
		});
	});
})();
