using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class HouseWithImagesWithAddressDtos : EntityDtos
    {
        public string Status { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public decimal SquareMeter { get; set; }
        public int CountOfRooms { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }

        public AddressDtos Address { get; set; }
        public List<ImageDtos> Images { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
