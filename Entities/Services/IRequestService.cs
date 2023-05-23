using Entities.Models;

namespace Entities.Services
{
    public interface IRequestService : IService<Request>
    {
        Task<List<Request>> GetByUserIdAsync(int userId);
        Task<List<Request>> GetByUserNameAsync(string name);
        Task DeleteByUserIdAsync(int userId);
        Task DeleteByUserNameAsync(string userName);
    }
}
