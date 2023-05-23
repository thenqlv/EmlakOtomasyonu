using Client;

new UserService().UpdateUserWithCommunication(new Entities.DTOs.UserWithCommunicationDtos()
{
    Id = 1,
    Email = "furkan",
    UserName = "furkan",
    Password = "123456",
    Communication = new Entities.DTOs.CommunicationDtos()
    {
        Name = "furkan",
        Surname = "furkan"
    }
});