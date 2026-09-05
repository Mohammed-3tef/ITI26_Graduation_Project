using AutoMapper;
using Mazeed.BLL.Responses;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;

namespace Mazeed.BLL.Services.Implementation
{
    public class ItemService : IItemService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IItemRepository _itemRepository;
        private readonly IMapper _mapper;

        public ItemService(IUnitOfWork unitOfWork, IItemRepository itemRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _itemRepository = itemRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<IEnumerable<ItemVM>>> GetAllAsync()
        {
            var items = await _itemRepository.GetAllWithDetailsAsync();
            var mappedItems = _mapper.Map<IEnumerable<ItemVM>>(items);
            return ServiceResponse<IEnumerable<ItemVM>>.SuccessResponse(mappedItems);
        }

        public async Task<ServiceResponse<ItemVM>> GetByIdAsync(long id)
        {
            var item = await _itemRepository.GetByIdWithDetailsAsync(id);
            if (item == null)
            {
                return ServiceResponse<ItemVM>.FailureResponse("Item not found.");
            }

            var mappedItem = _mapper.Map<ItemVM>(item);
            return ServiceResponse<ItemVM>.SuccessResponse(mappedItem);
        }

        public async Task<ServiceResponse<ItemVM>> CreateAsync(ItemVM model)
        {
            var itemEntity = _mapper.Map<Item>(model);
            itemEntity.CreatedBy = "Admin";
            itemEntity.CreatedAt = DateTime.Now;
            await _unitOfWork.Repository<Item>().AddAsync(itemEntity);
            var result = await _unitOfWork.CompleteAsync();

            if (result > 0)
            {
                var createdVM = _mapper.Map<ItemVM>(itemEntity);
                return ServiceResponse<ItemVM>.SuccessResponse(createdVM, "Item created successfully.");
            }

            return ServiceResponse<ItemVM>.FailureResponse("Failed to create item.");
        }

        public async Task<ServiceResponse<bool>> UpdateAsync(ItemVM model)
        {
            // 1. Fetch existing item including its current ItemCategories from DB
            var existingItem = await _itemRepository.GetByIdWithDetailsAsync(model.Id);
            if (existingItem == null)
            {
                return ServiceResponse<bool>.FailureResponse("Item not found.");
            }

            // 2. Map basic properties (Name, Price, BrandId)
            _mapper.Map(model, existingItem);

            // 3. Clear existing join records in memory
            existingItem.ItemCategories.Clear();

            // 4. Re-add new join records based on submitted CategoryIds
            foreach (var categoryId in model.CategoryIds)
            {
                existingItem.ItemCategories.Add(new ItemCategory
                {
                    ItemId = existingItem.Id,
                    CategoryId = categoryId
                });
            }

            _unitOfWork.Repository<Item>().Update(existingItem);

            // 5. THIS IS WHEN DELETIONS & INSERTS SAVE TO THE ItemCategory TABLE
            var result = await _unitOfWork.CompleteAsync();

            if (result > 0)
            {
                return ServiceResponse<bool>.SuccessResponse(true, "Item updated successfully.");
            }

            return ServiceResponse<bool>.FailureResponse("Failed to update item.");
        }
        public async Task<ServiceResponse<bool>> DeleteAsync(long id)
        {
            var item = await _unitOfWork.Repository<Item>().GetByIdAsync(id);
            if (item == null)
            {
                return ServiceResponse<bool>.FailureResponse("Item not found.");
            }

            _unitOfWork.Repository<Item>().Delete(item);
            var result = await _unitOfWork.CompleteAsync();

            if (result > 0)
            {
                return ServiceResponse<bool>.SuccessResponse(true, "Item deleted successfully.");
            }

            return ServiceResponse<bool>.FailureResponse("Failed to delete item.");
        }
    }
}