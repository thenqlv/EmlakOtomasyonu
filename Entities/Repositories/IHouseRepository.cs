using Entities.Models;
using Entities.Repositories;

namespace DataAccess.Repositories
{
    public interface IHouseRepository : IRepository<House>
    {
        Task<List<House>> GetByRequestAsync(Request request);
        Task<List<House>> GetByUserIdAsync(int userId);
        Task<List<House>> GetByUserNameAsync(string userName);
        Task<House> GetWithAddressAndImagesByIdAsync(int id);
        Task DeleteByRequestAsync(Request request);
        Task DeleteByUserIdAsync(int userId);
        Task DeleteByUserNameAsync(string userName);
    }
}
