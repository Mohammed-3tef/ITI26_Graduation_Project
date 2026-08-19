using AutoMapper;
using Mazeed.BLL.Responses;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;

namespace Mazeed.BLL.Services.Implementation
{
    public class BrandService : IBrandService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BrandService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<IEnumerable<BrandVM>>> GetAllAsync()
        {
            var brands = await _unitOfWork.Repository<Brand>().GetAllAsync();
            var mappedBrands = _mapper.Map<IEnumerable<BrandVM>>(brands);
            return ServiceResponse<IEnumerable<BrandVM>>.SuccessResponse(mappedBrands);
        }

        public async Task<ServiceResponse<BrandVM>> GetByIdAsync(long id)
        {
            var brand = await _unitOfWork.Repository<Brand>().GetByIdAsync(id);
            if (brand == null)
            {
                return ServiceResponse<BrandVM>.FailureResponse("Brand not found.");
            }

            var mappedBrand = _mapper.Map<BrandVM>(brand);
            return ServiceResponse<BrandVM>.SuccessResponse(mappedBrand);
        }

        public async Task<ServiceResponse<BrandVM>> CreateAsync(BrandVM model)
        {
            var brandEntity = _mapper.Map<Brand>(model);
            await _unitOfWork.Repository<Brand>().AddAsync(brandEntity);
            var result = await _unitOfWork.CompleteAsync();

            if (result > 0)
            {
                var createdVM = _mapper.Map<BrandVM>(brandEntity);
                return ServiceResponse<BrandVM>.SuccessResponse(createdVM, "Brand created successfully.");
            }

            return ServiceResponse<BrandVM>.FailureResponse("Failed to create brand.");
        }

        public async Task<ServiceResponse<bool>> UpdateAsync(BrandVM model)
        {
            var existingBrand = await _unitOfWork.Repository<Brand>().GetByIdAsync(model.Id);
            if (existingBrand == null)
            {
                return ServiceResponse<bool>.FailureResponse("Brand not found.");
            }

            _mapper.Map(model, existingBrand);
            _unitOfWork.Repository<Brand>().Update(existingBrand);
            var result = await _unitOfWork.CompleteAsync();

            if (result > 0)
            {
                return ServiceResponse<bool>.SuccessResponse(true, "Brand updated successfully.");
            }

            return ServiceResponse<bool>.FailureResponse("Failed to update brand.");
        }

        public async Task<ServiceResponse<bool>> DeleteAsync(long id)
        {
            var brand = await _unitOfWork.Repository<Brand>().GetByIdAsync(id);
            if (brand == null)
            {
                return ServiceResponse<bool>.FailureResponse("Brand not found.");
            }

            _unitOfWork.Repository<Brand>().Delete(brand);
            var result = await _unitOfWork.CompleteAsync();

            if (result > 0)
            {
                return ServiceResponse<bool>.SuccessResponse(true, "Brand deleted successfully.");
            }

            return ServiceResponse<bool>.FailureResponse("Failed to delete brand.");
        }
    }
}