using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class UserDtos:EntityDtos,GetController
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public string GetControllerName()
        {
            return "user/";
        }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
