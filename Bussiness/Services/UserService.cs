using DataAccess.Repositories;
using Entities.Models;
using Entities.Repositories;
using Entities.Services;
using Entities.UnitOfWorks;

namespace Bussiness.Services
{
    public class UserService : Service<User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IRepository<User> repository,IUserRepository userRepository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
            _userRepository = userRepository;
        }

        public async Task DeleteByEmailAsync(string email)
        {
             await _userRepository.DeleteByEmailAsync(email);
            _unitOfWork.CommitAsync();
        }

        public async Task DeleteByUserNameAsync(string userName)
        {
            await _userRepository.DeleteByUserNameAsync(userName);
            await _unitOfWork.CommitAsync();
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await _userRepository.GetByEmailAsync(email);
        }

        public async Task<User> GetByIdWithCommunicationsAsync(int id)
        {
            return await _userRepository.GetByIdWithCommunicationsAsync(id);
        }

        public async Task<User> GetByUserNameAsync(string userName)
        {
            return await _userRepository.GetByUserNameAsync(userName);
        }

        
    }
}
