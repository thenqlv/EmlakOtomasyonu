using Entities.Models;
using Entities.Repositories;

namespace DataAccess.Repositories
{
    public interface IRequestRepository : IRepository<Request>
    {
        Task<List<Request>> GetByUserIdAsync(int userId);
        Task<List<Request>> GetByUserNameAsync(string name);
        Task DeleteByUserIdAsync(int userId);
        Task DeleteByUserNameAsync(string userName);
    }
}
