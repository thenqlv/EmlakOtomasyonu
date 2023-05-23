
using System.Text.Json;

namespace Entities.DTOs
{
    public class HouseDtos:EntityDtos,GetController
    {
        public string Status { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public decimal SquareMeter { get; set; }
        public int CountOfRooms { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }

        public string GetControllerName()
        {
            return "house/";
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
