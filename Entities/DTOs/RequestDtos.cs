using System.Text.Json;

namespace Entities.DTOs
{
    public class RequestDtos : EntityDtos,GetController
    {
        public string? Status { get; set; }

        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string NeighbourhoodName { get; set; }

        public string? Type { get; set; }

        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        public decimal? MinSquareMeter { get; set; }
        public decimal? MaxSquareMeter { get; set; }

        public int? MinCountOfRooms { get; set; }
        public int? MaxCountOfRooms { get; set; }

        public int UserId { get; set; }

        public string GetControllerName()
        {
            return "request/";
        }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
