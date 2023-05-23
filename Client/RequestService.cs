using Entities;
using Entities.DTOs;
using System.Text.Json;

namespace Client
{
    public class RequestService : Service<RequestDtos>
    {

        private JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public List<RequestDtos> GetByUserId(int userId)
        {
            string json = DataExchange.Get("request/userid/" + userId);
            if (json != "[]")
                return JsonSerializer.Deserialize<List<RequestDtos>>(
                    json,
                    options
                );
            return new List<RequestDtos> { };
        }

        public List<RequestDtos> GetByUserName(string name)
        {
            string json = DataExchange.Get("request/username/" + name);
            if (json != "[]")
                return JsonSerializer.Deserialize<List<RequestDtos>>(
                    json,
                    options
                );
            return new List<RequestDtos> {};
        }
        
        public string DeleteByUserId(int userId)
        {
            return DataExchange.Delete("request/userid/" + userId);
        }

        public string DeleteByUserName(string userName)
        {
            return DataExchange.Delete("request/username/" + userName);
        }
    }
}
