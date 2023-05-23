
namespace Entities.Repositories
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> CreateAsync(T data);
        T Update(T data);
        T Delete(T data);
    }
}
