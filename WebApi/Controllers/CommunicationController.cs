using AutoMapper;
using Bussiness.Services;
using Entities.DTOs;
using Entities.Models;
using Entities.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class CommunicationController : Controller
    {
        private ICommunicationService _service;
        private IMapper _mapper;
        public CommunicationController(ICommunicationService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<CommunicationDtos>> GetAllAsync()
        {
            return _mapper.Map<List<CommunicationDtos>>(await _service.GetAllAsync());
        }

        [HttpGet("id/{id}")]
        public async Task<CommunicationDtos> GetByIdAsync(int id)
        {
            return _mapper.Map<CommunicationDtos>(await _service.GetByIdAsync(id));
        }

        [HttpGet("username/{userName}")]
        public async Task<CommunicationDtos> GetByUserNameAsync(string username)
        {
            return _mapper.Map<CommunicationDtos>(await _service.GetByUserNameAsync(username));
        }

        [HttpGet("userid/{userId}")]
        public async Task<CommunicationDtos> GetByUserIdAsync(int userId)
        {
            return _mapper.Map<CommunicationDtos>(await _service.GetByUserIdAsync(userId));
        }

        [HttpPost]
        public async Task<CommunicationDtos> PostAsync([FromBody] CommunicationDtos communication)
        {
            return _mapper.Map<CommunicationDtos>(await _service.CreateAsync(_mapper.Map<Communication>(communication)));
        }

        [HttpPut]
        public async Task PutAsync([FromBody] CommunicationDtos communication)
        {
            await _service.UpdateAsync(_mapper.Map<Communication>(communication));
        }

        [HttpDelete("id/{id}")]
        public async Task DeleteAsync(int id)
        {
            await _service.DeleteAsync(await _service.GetByIdAsync(id));
        }

        [HttpDelete("username/{userName}")]
        public async Task DeleteByUserNameAsync(string username)
        {
            await _service.DeleteByUserNameAsync(username);
        }

        [HttpDelete("userid/{userId}")]
        public async Task DeleteByUserIdAsync(int userId)
        {
            await _service.DeleteByUserIdAsync(userId);
        }

    }
}
