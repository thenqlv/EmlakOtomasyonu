using System.Text.Json;

namespace Entities.DTOs
{
    public class UserWithCommunicationDtos : EntityDtos
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public CommunicationDtos Communication { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
