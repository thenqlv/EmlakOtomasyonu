using Entities.Models;
using Entities.Repositories;

namespace DataAccess.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByUserNameAsync(string userName);
        Task<User> GetByEmailAsync(string email);
        Task<User> GetByIdWithCommunicationsAsync(int id);
        Task DeleteByUserNameAsync(string userName);
        Task DeleteByEmailAsync(string email);
        void UpdateUserWithCommunication(User user);
    }
}
