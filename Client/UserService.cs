using Entities;
using Entities.DTOs;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;

namespace Client
{
    public class UserService : Service<UserDtos>
    {
        private JsonSerializerOptions options = new() {
            PropertyNameCaseInsensitive = true 
        };

        public UserDtos GetByEmail(string email)
        {
            string json = DataExchange.Get("user/email/" + email);
            if(json != "")
                return JsonSerializer.Deserialize<UserDtos>(
                   json,
                    options
                );
            return new UserDtos();
        }

        public UserDtos GetByUserName(string username)
        {
            string json = DataExchange.Get("user/username/" + username);
            if(json != "")
                return JsonSerializer.Deserialize<UserDtos>(
                    json,
                    options
                );
            return new UserDtos();
        }
        public UserWithCommunicationDtos GetByIdWithCommunication(int id)
        {
            string json = DataExchange.Get("user/GetByIdWithCommunication/" + id);
            if (json != "")
                return JsonSerializer.Deserialize<UserWithCommunicationDtos>(
                    json,
                    options
                );
            return new UserWithCommunicationDtos();
        }
        
        public UserWithCommunicationDtos UpdateUserWithCommunication(UserWithCommunicationDtos data)
        {
            return JsonSerializer.Deserialize<UserWithCommunicationDtos>(
                DataExchange.Put("user/PutUserWithCommunication", data.ToString()),
                options
            );
        }

        public string DeleteByUserName(string userName)
        {
            return DataExchange.Delete("user/username/" + userName);
        }

        public string DeleteByEmail(string email)
        {
            return DataExchange.Delete("user/email/" + email);
        }

    }
}
