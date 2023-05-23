using DataAccess.Repositories;
using Entities.Models;
using Entities.Repositories;
using Entities.Services;
using Entities.UnitOfWorks;

namespace Bussiness.Services
{
    public class CommunicationService : Service<Communication>, ICommunicationService
    {
        private readonly ICommunicationRepository _communicationRepository;
        public CommunicationService(IRepository<Communication> repository,ICommunicationRepository communicationRepository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
            _communicationRepository = communicationRepository;
        }

        public async Task DeleteByUserIdAsync(int userId)
        {
            await _communicationRepository.DeleteByUserIdAsync(userId);
            _unitOfWork.CommitAsync();
        }
        public async Task DeleteByUserNameAsync(string userName)
        {
            await _communicationRepository.DeleteByUserNameAsync(userName);
            _unitOfWork.CommitAsync();
        }

        public async Task<Communication> GetByUserIdAsync(int userId)
        {
            return await _communicationRepository.GetByUserIdAsync(userId);
        }

        public async Task<Communication> GetByUserNameAsync(string userName)
        {
            return await _communicationRepository.GetByUserNameAsync(userName);
        }
    }
}
