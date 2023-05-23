
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {

        public UserRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<User> GetByUserNameAsync(string userName)
        {
            return await _appDbContext.Users.SingleOrDefaultAsync(u => u.UserName == userName);
        }


        public async Task<User> GetByEmailAsync(string email)
        {
            return await _appDbContext.Users.SingleOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User> GetByIdWithCommunicationsAsync(int id)
        {
            return await _appDbContext.Users.Include(u => u.Communication).SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task DeleteByEmailAsync(string email)
        {
            User user = await GetByEmailAsync(email);
            if(user != null)
                _appDbContext.Remove(user);
        }

        public async Task DeleteByUserNameAsync(string userName)
        {
            User user = await GetByUserNameAsync(userName);
            if( user != null )
                _appDbContext.Remove(user);
        }
       
        public void UpdateUserWithCommunication(User user)
        {
            
        }


        
    }
}
