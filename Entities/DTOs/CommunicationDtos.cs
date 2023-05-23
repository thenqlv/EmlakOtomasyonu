
using System.Text.Json;

namespace Entities.DTOs
{
    public class CommunicationDtos:EntityDtos, GetController
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? PhoneNumber { get; set; }
        public int UserId { get; set; }

        public string GetControllerName()
        {
            return "communication/";
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
