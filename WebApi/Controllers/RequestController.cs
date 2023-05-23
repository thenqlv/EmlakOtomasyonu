using AutoMapper;
using Entities;
using Entities.DTOs;
using Entities.Models;
using Entities.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class RequestController : Controller
    {

        private IRequestService _service;
        private IMapper _mapper;

        public RequestController(IRequestService service,IMapper mapper) {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<RequestDtos>> GetAllAsync()
        {
            return _mapper.Map<List<RequestDtos>>(await _service.GetAllAsync());
        }

        [HttpGet("id/{id}")]
        public async Task<RequestDtos> GetByIdAsync(int id)
        {
            return _mapper.Map<RequestDtos>(await _service.GetByIdAsync(id));
        }

        [HttpGet("userid/{id}")]
        public async Task<List<RequestDtos>> GetByUserIdAsync(int id)
        {
            return _mapper.Map<List<RequestDtos>>(await _service.GetByUserIdAsync(id));
        }

        [HttpGet("username/{username}")]
        public async Task<List<RequestDtos>> GetByUserNameAsync(string username)
        {
            return _mapper.Map<List<RequestDtos>>(await _service.GetByUserNameAsync(username));
        }

        [HttpPost]
        public async Task<RequestDtos> PostAsync([FromBody]RequestDtos request) {
            return _mapper.Map<RequestDtos>(await _service.CreateAsync(_mapper.Map<Request>(request)));
        }

        [HttpPut]
        public async Task PutAsync([FromBody] RequestDtos request)
        {
            await _service.UpdateAsync(_mapper.Map<Request>(request));
        }

        [HttpDelete("id/{id}")]
        public async Task DeleteAsync(int id)
        {
            await _service.DeleteAsync(await _service.GetByIdAsync(id));
        }

        [HttpDelete("userid/{id}")]
        public async Task DeleteByUserIdAsync(int id)
        {
            await _service.DeleteByUserIdAsync(id);
        }

        [HttpDelete("username/{username}")]
        public async Task DeleteByUserNameAsync(string username)
        {
            await _service.DeleteByUserNameAsync(username);
        }
    }
}
