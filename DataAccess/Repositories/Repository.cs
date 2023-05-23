using Entities.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {

        protected readonly AppDbContext _appDbContext;
        private readonly DbSet<T> _dbSet;

        public Repository(AppDbContext appDbContext)
        {
           _appDbContext = appDbContext;
            _dbSet = appDbContext.Set<T>();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> CreateAsync(T data)
        {
            await _dbSet.AddAsync(data);
            return data;
        }

        public T Update(T data)
        {
            _dbSet.Update(data);
            return data;
        }

        public T Delete(T data)
        {
            _dbSet.Remove(data);
            return data;
        }
    }
}
