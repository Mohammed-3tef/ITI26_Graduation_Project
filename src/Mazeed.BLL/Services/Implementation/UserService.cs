using AutoMapper;
using Mazeed.BLL.Helpers;
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

        public async Task<IEnumerable<UserVM>> GetAllUsersAsync()
        {
            var users = await _unitOfWork.Repository<User>().GetAllAsync();

            return _mapper.Map<IEnumerable<UserVM>>(users);
        }

        public async Task<UserVM?> GetUserByEmailAsync(string email)
        {
            var user = await _unitOfWork.Repository<User>().FindAsync(u => u.Email == email);
            var firstUser = user.FirstOrDefault();
            if (firstUser == null) return null;

            return _mapper.Map<UserVM>(firstUser);
        }

        public async Task<UserVM?> GetUserByNameAsync(string name)
        {
            var user = await _unitOfWork.Repository<User>().FindAsync(u => u.UserName == name);
            var firstUser = user.FirstOrDefault();
            if (firstUser == null) return null;

            return _mapper.Map<UserVM>(firstUser);
        }

        public async Task<UserVM?> GetUserByPhoneNumberAsync(string phoneNumber)
        {
            var user = await _unitOfWork.Repository<User>().FindAsync(u => u.PhoneNumber == phoneNumber);
            var firstUser = user.FirstOrDefault();
            if (firstUser == null) return null;

            return _mapper.Map<UserVM>(firstUser);
        }

        public async Task<bool> UpdateUserProfileAsync(UserVM model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null) return false;

            // 1. Handle image upload if a new picture is provided
            if (model.ProfileImage != null)
            {
                // Delete old image if present
                if (!string.IsNullOrEmpty(user.ImageUrl))
                {
                    DocumentSettings.DeleteFile(user.ImageUrl, "users");
                }

                user.ImageUrl = DocumentSettings.UploadFile(model.ProfileImage, "users");
            }

            // 2. Update properties
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.PhoneNumber = model.PhoneNumber;
            user.BirthDate = model.BirthDate;
            user.Gender = model.Gender == "Male" ? 'M' : 'F';
            user.CityId = int.Parse(model.City);
            user.City = await _cityRepository.GetByIdAsync(int.Parse(model.City));
            user.Street = model.Street;
            user.UpdatedBy = user.UserName;
            user.UpdatedAt = DateTime.UtcNow;

            var result = await _userManager.UpdateAsync(user);
            return result.Succeeded;
        }
    }
}
