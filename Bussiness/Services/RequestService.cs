using DataAccess.Repositories;
using Entities.Models;
using Entities.Repositories;
using Entities.Services;
using Entities.UnitOfWorks;

namespace Bussiness.Services
{
    public class RequestService : Service<Request>, IRequestService
    {
        private readonly IRequestRepository _requestRepository;
        public RequestService(IRepository<Request> repository,IRequestRepository requestRepository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
            _requestRepository = requestRepository;
        }

        public async Task DeleteByUserIdAsync(int userId)
        {
            await _requestRepository.DeleteByUserIdAsync(userId);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteByUserNameAsync(string userName)
        {
            await _requestRepository.DeleteByUserNameAsync(userName);
            await _unitOfWork.CommitAsync();
        }

        public async Task<List<Request>> GetByUserIdAsync(int userId)
        {
            return await _requestRepository.GetByUserIdAsync(userId);
        }

        public async Task<List<Request>> GetByUserNameAsync(string name)
        {
            return await _requestRepository.GetByUserNameAsync(name);
        }
    }
}
