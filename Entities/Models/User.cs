
using System.Text.Json;

namespace Entities.Models
{
    public class User : Entity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public Communication? Communication { get; set; }

        public List<House> Houses { get; set; } = new List<House>();
        public List<Request> Requests { get; set; } = new List<Request>();


        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
