using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class CommunicationRepository : Repository<Communication>, ICommunicationRepository
    {
        public CommunicationRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }


        public async Task<Communication> GetByUserIdAsync(int userId)
        {
            return await _appDbContext.Communications
                    .SingleOrDefaultAsync(c => c.Id == userId);
        }

        public async Task<Communication> GetByUserNameAsync(string userName)
        {
            return await _appDbContext.Communications
                    .SingleOrDefaultAsync(c => c.User.UserName == userName);
        }

        public async Task DeleteByUserIdAsync(int userId)
        {
            Communication communication = await GetByUserIdAsync(userId);
            if (communication != null)
                _appDbContext.Remove(communication);
        }

        public async Task DeleteByUserNameAsync(string userName)
        {
            Communication communication = await GetByUserNameAsync(userName);
            if (communication != null)
                _appDbContext.Remove(communication);
        }

        
    }
}
