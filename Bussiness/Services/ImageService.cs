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
    public class ImageService : Service<Image>, IImageService
    {
        public ImageService(IRepository<Image> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
