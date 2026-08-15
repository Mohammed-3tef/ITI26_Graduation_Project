using AutoMapper;
using Mazeed.BLL.Helpers;
using Mazeed.BLL.Responses;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels.User;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;
using Microsoft.AspNetCore.Identity;

namespace Mazeed.BLL.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly ICityRepository _cityRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, UserManager<User> userManager, IMapper mapper, ICityRepository cityRepository)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _mapper = mapper;
            _cityRepository = cityRepository;
        }

        public async Task<ServiceResponse<IEnumerable<UserVM>>> GetAllUsersAsync()
        {
            var users = await _unitOfWork.Repository<User>().GetAllAsync();

            return ServiceResponse<IEnumerable<UserVM>>.SuccessResponse(
                _mapper.Map<IEnumerable<UserVM>>(users),
                "Users retrieved successfully."
            );
        }

        public async Task<ServiceResponse<UserVM?>> GetUserByEmailAsync(string email)
        {
            var user = await _unitOfWork.Repository<User>().FindAsync(u => u.Email == email);
            var firstUser = user.FirstOrDefault();
            if (firstUser == null) 
                return ServiceResponse<UserVM?>.FailureResponse("User not found.");

            return ServiceResponse<UserVM?>.SuccessResponse(
                _mapper.Map<UserVM>(firstUser),
                "User retrieved successfully."
            );
        }

        public async Task<ServiceResponse<UserVM?>> GetUserByNameAsync(string name)
        {
            var user = await _unitOfWork.Repository<User>().FindAsync(u => u.UserName == name);
            var firstUser = user.FirstOrDefault();
            if (firstUser == null)
                return ServiceResponse<UserVM?>.FailureResponse("User not found.");

            return ServiceResponse<UserVM?>.SuccessResponse(
                _mapper.Map<UserVM>(firstUser),
                "User retrieved successfully."
            );
        }

        public async Task<ServiceResponse<UserVM?>> GetUserByPhoneNumberAsync(string phoneNumber)
        {
            var user = await _unitOfWork.Repository<User>().FindAsync(u => u.PhoneNumber == phoneNumber);
            var firstUser = user.FirstOrDefault();
            if (firstUser == null)
                return ServiceResponse<UserVM?>.FailureResponse("User not found.");

            return ServiceResponse<UserVM?>.SuccessResponse(
                _mapper.Map<UserVM>(firstUser),
                "User retrieved successfully."
            );
        }

        public async Task<ServiceResponse<bool>> UpdateUserProfileAsync(UserVM model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null) 
                return ServiceResponse<bool>.FailureResponse("User not found.");

            // 1. Update properties
            var city = await _cityRepository.GetByIdAsync(int.Parse(model.City));

            // 2. Handle image upload if a new picture is provided
            if (model.ProfileImage != null)
            {
                // Delete old image if present
                if (!string.IsNullOrEmpty(user.ImageUrl))
                    DocumentSettings.DeleteFile(user.ImageUrl, "users");

                user.Update(
                    model.FirstName, model.LastName, model.PhoneNumber, model.BirthDate, 
                    model.Gender, DocumentSettings.UploadFile(model.ProfileImage, "users"), 
                    city?.Id, city, model.Street, user?.UserName);
            }
            else
            {
                user.Update(model.FirstName, model.LastName, model.PhoneNumber, model.BirthDate, 
                    model.Gender, null, city?.Id, city, model.Street, user?.UserName);
            }

            var result = await _userManager.UpdateAsync(user);
            return result.Succeeded
                ? ServiceResponse<bool>.SuccessResponse(true, "User updated successfully.")
                : ServiceResponse<bool>.FailureResponse("Update user failed.");
        }
    }
}
