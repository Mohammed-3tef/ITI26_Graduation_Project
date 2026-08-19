using AutoMapper;
using Mazeed.BLL.Responses;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;

namespace Mazeed.BLL.Services.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<IEnumerable<CategoryVM>>> GetAllAsync()
        {
            var categories = await _unitOfWork.Repository<Category>().GetAllAsync();
            var mappedCategories = _mapper.Map<IEnumerable<CategoryVM>>(categories);
            return ServiceResponse<IEnumerable<CategoryVM>>.SuccessResponse(mappedCategories);
        }

        public async Task<ServiceResponse<CategoryVM>> GetByIdAsync(long id)
        {
            var category = await _unitOfWork.Repository<Category>().GetByIdAsync(id);
            if (category == null)
            {
                return ServiceResponse<CategoryVM>.FailureResponse("Category not found.");
            }

            var mappedCategory = _mapper.Map<CategoryVM>(category);
            return ServiceResponse<CategoryVM>.SuccessResponse(mappedCategory);
        }

        public async Task<ServiceResponse<CategoryVM>> CreateAsync(CategoryVM model)
        {
            var categoryEntity = _mapper.Map<Category>(model);
            await _unitOfWork.Repository<Category>().AddAsync(categoryEntity);
            var result = await _unitOfWork.CompleteAsync();

            if (result > 0)
            {
                var createdVM = _mapper.Map<CategoryVM>(categoryEntity);
                return ServiceResponse<CategoryVM>.SuccessResponse(createdVM, "Category created successfully.");
            }

            return ServiceResponse<CategoryVM>.FailureResponse("Failed to create category.");
        }

        public async Task<ServiceResponse<bool>> UpdateAsync(CategoryVM model)
        {
            var existingCategory = await _unitOfWork.Repository<Category>().GetByIdAsync(model.Id);
            if (existingCategory == null)
            {
                return ServiceResponse<bool>.FailureResponse("Category not found.");
            }

            _mapper.Map(model, existingCategory);
            _unitOfWork.Repository<Category>().Update(existingCategory);
            var result = await _unitOfWork.CompleteAsync();

            if (result > 0)
            {
                return ServiceResponse<bool>.SuccessResponse(true, "Category updated successfully.");
            }

            return ServiceResponse<bool>.FailureResponse("Failed to update category.");
        }

        public async Task<ServiceResponse<bool>> DeleteAsync(long id)
        {
            var category = await _unitOfWork.Repository<Category>().GetByIdAsync(id);
            if (category == null)
            {
                return ServiceResponse<bool>.FailureResponse("Category not found.");
            }

            _unitOfWork.Repository<Category>().Delete(category);
            var result = await _unitOfWork.CompleteAsync();

            if (result > 0)
            {
                return ServiceResponse<bool>.SuccessResponse(true, "Category deleted successfully.");
            }

            return ServiceResponse<bool>.FailureResponse("Failed to delete category.");
        }
    }
}