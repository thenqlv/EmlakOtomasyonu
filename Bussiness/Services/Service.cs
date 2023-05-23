using Entities.Repositories;
using Entities.Services;
using Entities.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Services
{
    public class Service<T> : IService<T> where T : class
    {

        private readonly IRepository<T> _repository;
        protected readonly IUnitOfWork _unitOfWork;

        public Service(IRepository<T> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }


        public async Task<List<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }


        public async Task<T> CreateAsync(T data)
        {
            await _repository.CreateAsync(data);
            await _unitOfWork.CommitAsync();
            return data;
        }

        public async Task UpdateAsync(T data)
        {
            _repository.Update(data);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteAsync(T data)
        {
            _repository.Delete(data);
            await _unitOfWork.CommitAsync();
        }

    }
}
