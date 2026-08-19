using AutoMapper;
using Mazeed.BLL.Responses;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels.User;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;
using Microsoft.AspNetCore.Http;
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

            var city = await _cityRepository.GetByIdAsync(int.Parse(model.City));

            // Retain existing image byte array by default
            byte[]? imageBytes = user.ProfileImage;

            // Only overwrite if a new photo file was actually selected & uploaded
            if (model.ProfileImage != null && model.ProfileImage.Length > 0)
            {
                using var memoryStream = new MemoryStream();
                await model.ProfileImage.CopyToAsync(memoryStream);
                imageBytes = memoryStream.ToArray();
            }

            user.Update(
                model.FirstName,
                model.LastName,
                model.PhoneNumber,
                model.BirthDate,
                model.Gender,
                imageBytes,
                city?.Id,
                city,
                model.Street,
                user?.UserName);

            var result = await _userManager.UpdateAsync(user);
            return result.Succeeded
                ? ServiceResponse<bool>.SuccessResponse(true, "User updated successfully.")
                : ServiceResponse<bool>.FailureResponse("Update user failed.");
        }

        public async Task<ServiceResponse<bool>> UpdateUserProfileImageAsync(string username, IFormFile image)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user == null)
                return ServiceResponse<bool>.FailureResponse("المستخدم غير موجود.");

            using var memoryStream = new MemoryStream();
            await image.CopyToAsync(memoryStream);

            user.ProfileImage = memoryStream.ToArray();

            var result = await _userManager.UpdateAsync(user);
            return result.Succeeded
                ? ServiceResponse<bool>.SuccessResponse(true, "تم تحديث الصورة بنجاح.")
                : ServiceResponse<bool>.FailureResponse("فشل تحديث الصورة.");
        }
    }
}