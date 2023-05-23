using Entities.Models;
using Entities.Repositories;
using Entities.Services;
using Entities.UnitOfWorks;

namespace Bussiness.Services
{
    public class AddressService : Service<Address>,IAddressService
    {
        public AddressService(IRepository<Address> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
