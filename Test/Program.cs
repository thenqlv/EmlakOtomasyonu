using Client;
using Entities.DTOs;


var a = new UserWithCommunicationDtos()
{
    Id = 1,
    Password = "15",
    UserName = "furkan",
    Email = "furkan",
    Communication = new CommunicationDtos
    {
        Name = "Test",
        Surname = "Test",
        PhoneNumber = "Test"
        
    }
};

new UserService().UpdateUserWithCommunication(a);