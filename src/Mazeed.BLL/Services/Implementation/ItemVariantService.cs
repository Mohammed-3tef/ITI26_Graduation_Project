using AutoMapper;
using Mazeed.BLL.Responses;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;

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
            var existingVariant = await _unitOfWork.Repository<ItemVariant>().GetByIdAsync(model.Id);
            if (existingVariant == null)
            {
                return ServiceResponse<bool>.FailureResponse("Item variant not found.");
            }

            _mapper.Map(model, existingVariant);
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
    }
}