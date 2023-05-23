using Entities.Models;
using Entities.Repositories;

namespace DataAccess.Repositories
{
    public class ImageRepository : Repository<Image>,IImageRepository
    {
        public ImageRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
