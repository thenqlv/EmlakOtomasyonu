using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class RequestRepository : Repository<Request>,IRequestRepository
    {


        public RequestRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<List<Request>> GetByUserIdAsync(int userId)
        {
            return await _appDbContext.Requests
                   .Where(r => r.UserId == userId)
                   .ToListAsync();
        }

        public async Task<List<Request>> GetByUserNameAsync(string name)
        {
            return await _appDbContext.Requests.Where(r => r.User.UserName == name).ToListAsync();
        }


        public async Task DeleteByUserIdAsync(int userId)
        {
            List<Request> requests = await GetByUserIdAsync(userId);
            if (requests != null)
            {
                _appDbContext.Requests.RemoveRange(requests);
            }
        }

        public async Task DeleteByUserNameAsync(string userName)
        {
            List<Request> requests = await GetByUserNameAsync(userName);
            if (requests != null)
            {
                _appDbContext.Requests.RemoveRange(requests);
            }
        }

       
    }
}
