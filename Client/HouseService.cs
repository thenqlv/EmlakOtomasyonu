using Entities;
using Entities.DTOs;
using System.Text.Json;

namespace Client
{
    public class HouseService : Service<HouseDtos>
    {

        private JsonSerializerOptions options = new()
        {
            PropertyNameCaseInsensitive = true
        };


        public List<HouseDtos> GetByUserId(int userId)
        {
            string json = DataExchange.Get("house/userid/" + userId);
            if (json != "[]")
                return JsonSerializer.Deserialize<List<HouseDtos>>(
                    json,
                    options
                );
            return new List<HouseDtos>();
        }
        
        public List<HouseDtos> GetByUserName(string userName)
        {
            string json = DataExchange.Get("house/username/" + userName);
            if (json != "[]")
                return JsonSerializer.Deserialize<List<HouseDtos>>(
                    json,
                    options
                );
            return new List<HouseDtos>();
        }

        public HouseWithImagesWithAddressDtos GetWithAddressesAndImagesById(int id)
        {
            string json = DataExchange.Get("house/GetWithAddressAndImagesById/" + id);
            if (json != "")
                return JsonSerializer.Deserialize<HouseWithImagesWithAddressDtos>(
                    json,
                    options
                );
            return new HouseWithImagesWithAddressDtos();
        }
        public string DeleteByUserId(int userId)
        {
            return DataExchange.Delete("house/userid/" + userId);
        }

        public string DeleteByUserName(string userName)
        {
            return DataExchange.Delete("house/username/" + userName);
        }
    }
}
