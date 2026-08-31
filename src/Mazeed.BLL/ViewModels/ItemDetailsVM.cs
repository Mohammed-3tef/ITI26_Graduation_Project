namespace Mazeed.BLL.ViewModels;

public class ItemDetailsVM
{
    public ItemVM Product { get; set; } = new ItemVM();

    // جميع الفاريانتس المتاحة للمنتج
    public List<ItemVariantVM> Variants { get; set; } = new List<ItemVariantVM>();

    // قوائم مستخرجة للألوان والمقاسات بدون تكرار
    public List<string> AvailableColors { get; set; } = new List<string>();
    public List<string> AvailableSizes { get; set; } = new List<string>();

    // المقترحات
    public List<ItemVM> RelatedProducts { get; set; } = new List<ItemVM>();
}