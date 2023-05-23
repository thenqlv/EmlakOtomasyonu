using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class AddressRepository : Repository<Address>,IAddressRepository
    {
        public AddressRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
