
using System.Text.Json;

namespace Entities.Models
{
    public class Request : Entity
    {
        public string? Status { get; set; }

        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string NeighborhoodName { get; set; }
        
        public string? Type { get; set; }
        
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        
        public decimal? MinSquareMeter { get; set; }
        public decimal? MaxSquareMeter { get; set; }
        
        public int? MinCountOfRooms { get; set; }
        public int? MaxCountOfRooms { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
