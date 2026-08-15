using AutoMapper;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels.User;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;

namespace Mazeed.BLL.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserVM>> GetAllUsersAsync()
        {
            var users = await _unitOfWork.Repository<User>().GetAllAsync();

            return _mapper.Map<IEnumerable<UserVM>>(users);
        }

        public async Task<UserVM> GetUserByEmailAsync(string email)
        {
            var user = await _unitOfWork.Repository<User>().FindAsync(u => u.Email == email);
            var firstUser = user.FirstOrDefault();
            if (firstUser == null) return null;

            return _mapper.Map<UserVM>(firstUser);
        }

        public async Task<UserVM> GetUserByNameAsync(string name)
        {
            var user = await _unitOfWork.Repository<User>().FindAsync(u => u.UserName == name);
            var firstUser = user.FirstOrDefault();
            if (firstUser == null) return null;

            return _mapper.Map<UserVM>(firstUser);
        }

        public async Task<UserVM> GetUserByPhoneNumberAsync(string phoneNumber)
        {
            var user = await _unitOfWork.Repository<User>().FindAsync(u => u.PhoneNumber == phoneNumber);
            var firstUser = user.FirstOrDefault();
            if (firstUser == null) return null;

            return _mapper.Map<UserVM>(firstUser);
        }
    }
}
