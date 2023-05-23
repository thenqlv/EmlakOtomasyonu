using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Services
{
    public interface IService<T>
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> CreateAsync(T data);
        Task UpdateAsync(T data);
        Task DeleteAsync(T data);
    }
}
