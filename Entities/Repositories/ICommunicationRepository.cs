using Entities.Models;
using Entities.Repositories;

namespace DataAccess.Repositories
{
    public interface ICommunicationRepository : IRepository<Communication>
    {
        Task<Communication> GetByUserIdAsync(int userId);
        Task<Communication> GetByUserNameAsync(string userName);
        Task DeleteByUserIdAsync(int userId);
        Task DeleteByUserNameAsync(string userName);
    }
}
