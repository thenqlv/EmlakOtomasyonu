using System.Text.Json;
using Entities.DTOs;
namespace Client
{
    public class Service<T> where T : GetController,new()
    {
        private JsonSerializerOptions options = new()
        {
            PropertyNameCaseInsensitive = true
        };
        private string controllerName;
        public Service()
        {
            controllerName = new T().GetControllerName();
        }

        public List<T> GetAll(){
            string json = DataExchange.Get(controllerName);
            if(json != "[]")
                return JsonSerializer.Deserialize<List<T>>(
                    json, options
                );
            else
                return new List<T>() { };
        }
        public T GetById(int id)
        {
            string json = DataExchange.Get(controllerName + "id/" + id);
            if (json != "")
                return JsonSerializer.Deserialize<T>(
                    json, options
                );
            return new T();
        }
        public T Create(T t)
        {
            string data = t.ToString();
            return JsonSerializer.Deserialize<T>(
                DataExchange.Post(controllerName, data),
                options
            );
        }
        public T Update(T t)
        {
            return JsonSerializer.Deserialize<T>(
                DataExchange.Put(controllerName, t.ToString()),
                options
            );
        }

        public string Delete(int id)
        {
            return DataExchange.Delete(controllerName + "id/" + id);
        }
    }
}
