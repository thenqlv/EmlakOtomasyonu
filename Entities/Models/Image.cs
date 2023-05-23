

namespace Entities.Models
{
    public class Image : Entity
    {
        public string Name { get; set; }

        public int HouseId;
        public House House { get; set; }
    }
}
