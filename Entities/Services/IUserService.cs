using Entities.Models;

namespace Entities.Services
{
    public interface IUserService : IService<User>
    {
        Task<User> GetByUserNameAsync(string userName);
        Task<User> GetByEmailAsync(string email);
        Task<User> GetByIdWithCommunicationsAsync(int id);
        Task DeleteByUserNameAsync(string userName);
        Task DeleteByEmailAsync(string email);
        
    }
}
