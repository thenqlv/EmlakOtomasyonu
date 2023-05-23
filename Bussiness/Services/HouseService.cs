using DataAccess.Repositories;
using Entities.Models;
using Entities.Repositories;
using Entities.Services;
using Entities.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Services
{
    public class HouseService : Service<House>, IHouseService
    {
        private IHouseRepository _houseRepository;
        public HouseService(IRepository<House> repository,IHouseRepository houeRepository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
            _houseRepository = houeRepository;
        }

        public async Task DeleteByRequestAsync(Request request)
        {
            await _houseRepository.DeleteByRequestAsync(request);
            _unitOfWork.CommitAsync();
        }

        public async Task DeleteByUserIdAsync(int userId)
        {
            await _houseRepository.DeleteByUserIdAsync(userId);
            _unitOfWork.CommitAsync();
        }

        public async Task DeleteByUserNameAsync(string userName)
        {
            await _houseRepository.DeleteByUserNameAsync(userName);
            _unitOfWork.CommitAsync();
        }

        public async Task<List<House>> GetByRequestAsync(Request request)
        {
            return await _houseRepository.GetByRequestAsync(request);
        }

        public async Task<List<House>> GetByUserIdAsync(int userId)
        {
            return await _houseRepository.GetByUserIdAsync(userId);
        }

        public async Task<List<House>> GetByUserNameAsync(string userName)
        {
            return await _houseRepository.GetByUserNameAsync(userName);
        }

        public async Task<House> GetWithAddressAndImagesByIdAsync(int id)
        {
            return await _houseRepository.GetWithAddressAndImagesByIdAsync(id);
        }
    }
}
