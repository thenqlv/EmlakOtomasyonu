using System.Text.Json;

namespace Entities.Models
{
    public class Address : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string NeighborhoodName { get; set; }

        public string StreetName { get; set; }
        public int BuildingNumber { get; set; }
        public int Floor { get; set; }
        public int ApartmentNumber { get; set; }

        public bool IsCurrent { get; set; } = true;



        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
