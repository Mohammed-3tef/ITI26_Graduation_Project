using AutoMapper;
using Mazeed.BLL.Responses;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Mazeed.BLL.ViewModels.Search;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace Mazeed.BLL.Services.Implementation
{
    public class ItemVariantService : IItemVariantService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IItemVariantRepository _itemVariantRepository;
        private readonly IMapper _mapper;

        public ItemVariantService(
            IUnitOfWork unitOfWork,
            IItemVariantRepository itemVariantRepository,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _itemVariantRepository = itemVariantRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<IEnumerable<ItemVariantVM>>> GetAllAsync()
        {
            var variants = await _itemVariantRepository.GetAllWithDetailsAsync();
            var mappedVariants = _mapper.Map<IEnumerable<ItemVariantVM>>(variants);
            return ServiceResponse<IEnumerable<ItemVariantVM>>.SuccessResponse(mappedVariants);
        }

        public async Task<ServiceResponse<ItemVariantVM>> GetByIdAsync(long id)
        {
            var variant = await _itemVariantRepository.GetByIdWithDetailsAsync(id);
            if (variant == null)
            {
                return ServiceResponse<ItemVariantVM>.FailureResponse("Item variant not found.");
            }

            var mappedVariant = _mapper.Map<ItemVariantVM>(variant);
            return ServiceResponse<ItemVariantVM>.SuccessResponse(mappedVariant);
        }

        public async Task<ServiceResponse<ItemVariantVM>> CreateAsync(ItemVariantVM model)
        {
            var variantEntity = _mapper.Map<ItemVariant>(model);
            if (model.Photos != null && model.Photos.Any())
            {
                foreach (var url in model.Photos.Where(u => !string.IsNullOrWhiteSpace(u)))
                {
                    variantEntity.Photos.Add(new ItemVariantPhoto
                    {
                        PhotoUrl = url,
                        CreatedBy = "Admin",
                        CreatedAt = DateTime.Now
                    });
                }
            }
            variantEntity.CreatedBy = "Admin";
            variantEntity.CreatedAt = DateTime.Now;
            await _unitOfWork.Repository<ItemVariant>().AddAsync(variantEntity);
            var result = await _unitOfWork.CompleteAsync();

            if (result > 0)
            {
                var createdVM = _mapper.Map<ItemVariantVM>(variantEntity);
                return ServiceResponse<ItemVariantVM>.SuccessResponse(createdVM, "Item variant created successfully.");
            }

            return ServiceResponse<ItemVariantVM>.FailureResponse("Failed to create item variant.");
        }

        public async Task<ServiceResponse<bool>> UpdateAsync(ItemVariantVM model)
        {
            var existingVariant = await _itemVariantRepository.GetByIdWithDetailsAsync(model.Id);
            if (existingVariant == null)
            {
                return ServiceResponse<bool>.FailureResponse("Item variant not found.");
            }

            _mapper.Map(model, existingVariant);

            // Update Photos
            existingVariant.Photos.Clear();
            if (model.Photos != null && model.Photos.Any())
            {
                foreach (var url in model.Photos.Where(u => !string.IsNullOrWhiteSpace(u)))
                {
                    existingVariant.Photos.Add(new ItemVariantPhoto
                    {
                        PhotoUrl = url,
                        ItemVariantId = existingVariant.Id,
                        CreatedBy = "Admin",
                        CreatedAt = DateTime.Now
                    });
                }
            }

            existingVariant.UpdatedBy = "Admin";
            existingVariant.UpdatedAt = DateTime.Now;
            _unitOfWork.Repository<ItemVariant>().Update(existingVariant);
            var result = await _unitOfWork.CompleteAsync();

            if (result > 0)
            {
                return ServiceResponse<bool>.SuccessResponse(true, "Item variant updated successfully.");
            }

            return ServiceResponse<bool>.FailureResponse("Failed to update item variant.");
        }

        public async Task<ServiceResponse<bool>> DeleteAsync(long id)
        {
            var variant = await _unitOfWork.Repository<ItemVariant>().GetByIdAsync(id);
            if (variant == null)
            {
                return ServiceResponse<bool>.FailureResponse("Item variant not found.");
            }

            _unitOfWork.Repository<ItemVariant>().Delete(variant);
            var result = await _unitOfWork.CompleteAsync();

            if (result > 0)
            {
                return ServiceResponse<bool>.SuccessResponse(true, "Item variant deleted successfully.");
            }

            return ServiceResponse<bool>.FailureResponse("Failed to delete item variant.");
        }

        public async Task<ServiceResponse<IEnumerable<ColorItem>>> GetDistinctColors()
        {
            var variants = await _itemVariantRepository.GetAllAsync();
            var distinctColorNames = variants.Where(i => i.Color != null && i.Color != "")
    .Select(i => i.Color).Distinct().ToList();

            // 2. Define a map matching color names to their CSS Hex Codes
            var complexColorMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
{
    { "Beige", "#F5F5DC" },
    { "Black", "#000000" },
    { "Black / Red", "linear-gradient(135deg, #000000 50%, #FF0000 50%)" },
    { "Black / White", "linear-gradient(135deg, #000000 50%, #FFFFFF 50%)" },
    { "Black Titanium", "#3C3D3A" },
    { "Blue", "#0000FF" },
    { "Blue Titanium", "#465262" },
    { "Brownish Black", "#2B1E19" },
    { "Chili", "#C21E2A" },
    { "Clear", "rgba(255,255,255,0.2)" }, // Semi-transparent look
    { "Core Black", "#111111" },
    { "Core White", "#FAFAFA" },
    { "Dark Blue", "#00008B" },
    { "Grey", "#808080" },
    { "Heather Grey", "#A9A9A9" },
    { "Light Blue", "#ADD8E6" },
    { "Midnight Blue", "#191970" },
    { "Mint Green", "#98FF98" },
    { "Natural Titanium", "#BEB7A4" },
    { "Navy", "#000080" },
    { "Olive Green", "#808000" },
    { "Pastel Pink", "#FFB6C1" },
    { "Purple", "#800080" },
    { "Racer Blue", "#0053CD" },
    { "Red", "#FF0000" },
    { "Royal Blue", "#4169E1" },
    { "Ruby Woo", "#9B111E" }, // Famous matte deep red 
    { "Silver", "#C0C0C0" },
    { "Solar Red", "#FF4500" },
    { "Space Black", "#232426" },
    { "Titanium Black", "#212224" },
    { "Titanium Gray", "#5A5D64" },
    { "Titanium Violet", "#554D6C" },
    { "Total Orange", "#FF6600" },
    { "Translucent", "linear-gradient(45deg, #ccc 25%, transparent 25%), linear-gradient(-45deg, #ccc 25%, transparent 25%), linear-gradient(45deg, transparent 75%, #ccc 75%), linear-gradient(-45deg, transparent 75%, #ccc 75%)" }, // Checkerboard mesh pattern for translucent
    { "Velvet Teddy", "#BB8674" }, // Nude/Deep Beige makeup shade
    { "Very Black", "#050505" },
    { "Waterproof Black", "#0A0A0A" },
    { "White", "#FFFFFF" }
};
            List<ColorItem> AvailableColors = distinctColorNames.Select(colorName => new ColorItem
            {
                Name = colorName,
                HexCode = complexColorMap.TryGetValue(colorName.Trim(), out var visualValue) ? visualValue : "#D3D3D3"
            }).OrderBy(c => c.Name).ToList();

            return ServiceResponse<IEnumerable<ColorItem>>.SuccessResponse(AvailableColors);
        }
        public async Task<ServiceResponse<IEnumerable<string>>> GetDistinctSize()
        {
            var variants = await _itemVariantRepository.GetAllAsync();
            var distinctSizeNames = variants.Where(i => i.Size != null && i.Size != "")
    .Select(i => i.Size).Distinct().ToList();
            return ServiceResponse<IEnumerable<string>>.SuccessResponse(distinctSizeNames);
        }
    }
}