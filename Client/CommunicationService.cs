using Entities;
using Entities.DTOs;
using System.Text.Json;

namespace Client
{
    public class CommunicationService : Service<CommunicationDtos>
    {
        private JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public CommunicationDtos GetByUserId(int userId)
        {
            string json = DataExchange.Get("communication/userid/" + userId);
            if (json != "")
                return JsonSerializer.Deserialize<CommunicationDtos>(
                    json,
                    options
                );
            return new CommunicationDtos();
        }
        public CommunicationDtos GetByUserName(string userName)
        {
            string json = DataExchange.Get("communication/username/" + userName);
            if(json != "")
                return JsonSerializer.Deserialize<CommunicationDtos>(
                    json,
                    options
                );
            return new CommunicationDtos();
        }

        public string DeleteByUserId(int userId)
        {
            return DataExchange.Delete("communication/userid/" + userId);
        }

        public string DeleteByUserName(string userName)
        {
            return DataExchange.Delete("communication/username/" + userName);
        }



    }
}
