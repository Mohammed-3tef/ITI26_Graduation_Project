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
