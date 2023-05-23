

using Entities;
using System.Net;
using System.Text;

namespace Client
{
    public class DataExchange
    {
        public static string BASEURL = "http://localhost:5022/api/";

        private static HttpClient client = new() { BaseAddress = new Uri(BASEURL) };

        public static string Get(string option)
        {
            return
                new StreamReader(
                    WebRequest.Create(BASEURL + option).GetResponse().GetResponseStream()
                ).ReadToEnd();
        }

        public static string Post(string option,string data)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            WebRequest request = WebRequest.Create(BASEURL + option);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = bytes.Length;
            request.GetRequestStream().Write(bytes, 0, bytes.Length);
            
            return 
                new StreamReader(
                    request.GetResponse().GetResponseStream()
                ).ReadToEnd();
        }
        public static string Put(string option,string data)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            WebRequest request = WebRequest.Create(BASEURL + option);
            request.Method = "PUT";
            request.ContentType = "application/json";
            request.ContentLength = bytes.Length;
            request.GetRequestStream().Write(bytes, 0, bytes.Length);

            return
                new StreamReader(
                    request.GetResponse().GetResponseStream()
                ).ReadToEnd();
        }
        public static string Delete(string option)
        {
            WebRequest request = WebRequest.Create(BASEURL + option);
            request.Method = "DELETE";
            return
                new StreamReader(
                    request.GetResponse().GetResponseStream()
                ).ReadToEnd();
        }
    }
}
