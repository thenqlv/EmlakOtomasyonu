using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Services
{
    public interface ICommunicationService : IService<Communication>
    {
        Task<Communication> GetByUserIdAsync(int userId);
        Task<Communication> GetByUserNameAsync(string userName);
        Task DeleteByUserIdAsync(int userId);
        Task DeleteByUserNameAsync(string userName);
    }
}
