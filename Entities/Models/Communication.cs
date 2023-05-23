
using System.Text.Json;
using Entities.Models;

namespace Entities.Models
{
    public class Communication : Entity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? PhoneNumber { get; set; }
        public List<Address> Adresses { get; set; } = new List<Address>();

        public User User { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
