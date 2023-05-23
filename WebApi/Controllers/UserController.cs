using AutoMapper;
using Entities.DTOs;
using Entities.Models;
using Entities.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {

        private IUserService _service;
        private IMapper _mapper;

        public UserController(IUserService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<UserDtos>> GetAllAsync()
        {
            return _mapper.Map<List<UserDtos>>(await _service.GetAllAsync());
        }

        [HttpGet("id/{id}")]
        public async Task<UserDtos> GetByIdAsync(int id)
        {
            return _mapper.Map<UserDtos>(await _service.GetByIdAsync(id));
        }

        [HttpGet("username/{username}")]
        public async Task<UserDtos> GetByUserNameAsync(string username)
        {
            return _mapper.Map<UserDtos>(await _service.GetByUserNameAsync(username));
        }

        [HttpGet("email/{email}")]
        public async Task<UserDtos> GetByEmailAsync(string email)
        {
            return _mapper.Map<UserDtos>(await _service.GetByEmailAsync(email));
        }

        [HttpGet("GetByIdWithCommunication/{id}")]
        public async Task<UserWithCommunicationDtos> GetByIdWithCommunicationAsync(int id)
        {
            return _mapper.Map<UserWithCommunicationDtos>(await _service.GetByIdWithCommunicationsAsync(id));
        }

        [HttpPost]
        public async Task<UserDtos> PostAsync([FromBody]UserDtos user)
        {
            return _mapper.Map<UserDtos>(await _service.CreateAsync(_mapper.Map<User>(user)));
        }
        
        [HttpPut]
        public async Task PutAsync([FromBody] UserDtos user)
        {
            await _service.UpdateAsync(_mapper.Map<User>(user));
        }

        [HttpPut("PutUserWithCommunication")]
        public async Task PutUserWithCommunicationAsync([FromBody] UserWithCommunicationDtos user)
        {
            await _service.UpdateAsync(_mapper.Map<User>(user));
        }


        [HttpDelete("id/{id}")]
        public async Task DeleteAsync(int id)
        {
            await _service.DeleteAsync(await _service.GetByIdAsync(id));
        }

        [HttpDelete("username/{userName}")]
        public async Task DeleteByUserNameAsync(string userName)
        {
            await _service.DeleteByUserNameAsync(userName);
        }

        [HttpDelete("email/{email}")]
        public async Task DeleteByEmailAsync(string email)
        {
            await _service.DeleteByEmailAsync(email);
        }
    }
}
