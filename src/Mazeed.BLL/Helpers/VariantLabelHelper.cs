namespace Mazeed.BLL.Helpers
{
    public static class VariantLabelHelper
    {
        private static readonly Dictionary<string, (string Color, string Size)> _labels =
            new(StringComparer.OrdinalIgnoreCase)
            {
                ["Electronics"]    = ("Finish", "Configuration"),
                ["Fashion"]        = ("Color", "Size"),
                ["Sports"]         = ("Color", "Size"),
                ["Beauty"]         = ("Shade", "Size / Volume"),
                ["Footwear"]       = ("Color", "Shoe Size"),
                ["Books"]          = ("Cover Type", "Edition"),
                ["Furniture"]      = ("Material", "Dimensions"),
                ["Jewelry"]        = ("Metal", "Size"),
                ["Toys"]           = ("Color", "Age Range"),
                ["Automotive"]     = ("Color", "Fit / Model"),
                ["Groceries"]      = ("Flavor", "Weight / Pack Size"),
                ["Home & Kitchen"] = ("Color", "Size / Capacity"),
            };

        private static readonly (string Color, string Size) Default = ("Color", "Option");

        /// <summary>
        /// Checks every category a product belongs to (not just the first)
        /// and returns the first matching label pair, or a sensible default.
        /// </summary>
        public static (string Color, string Size) GetLabels(IEnumerable<string>? categoryNames)
        {
            if (categoryNames == null) return Default;

            foreach (var name in categoryNames)
            {
                if (!string.IsNullOrWhiteSpace(name) && _labels.TryGetValue(name, out var match))
                    return match;
            }

            return Default;
        }
    }
}