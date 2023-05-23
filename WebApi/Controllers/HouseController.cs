using AutoMapper;
using Entities.DTOs;
using Entities.Models;
using Entities.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class HouseController : Controller
    {
        private IHouseService _service;
        private IMapper _mapper;

        public HouseController(IHouseService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<HouseDtos>> GetAllAsync()
        {
            return _mapper.Map<List<HouseDtos>>(await _service.GetAllAsync());
        }

        [HttpGet("id/{id}")]
        public async Task<HouseDtos> GetByIdAsync(int id)
        {
            return _mapper.Map<HouseDtos>(await _service.GetByIdAsync(id));
        }

        [HttpGet("userid/{userId}")]
        public async Task<List<HouseDtos>> GetByUserIdAsync(int userId)
        {
            return _mapper.Map<List<HouseDtos>>(await _service.GetByUserIdAsync(userId));
        }

        [HttpGet("username/{userName}")]
        public async Task<List<HouseDtos>> GetByUserNameAsync(string userName)
        {
            return _mapper.Map<List<HouseDtos>>(await _service.GetByUserNameAsync(userName));
        }

        [HttpGet("GetWithAddressAndImagesById/{id}")]
        public async Task<HouseWithImagesWithAddressDtos> GetWithAddressAndImagesByUserIdAsync(int id)
        {
            return _mapper.Map<HouseWithImagesWithAddressDtos>(
                await _service.GetWithAddressAndImagesByIdAsync(id)
                );
        }
        [HttpPost]
        public async Task<HouseDtos> PostAsync([FromBody]HouseDtos house)
        {
            return _mapper.Map<HouseDtos>(await _service.CreateAsync(_mapper.Map<House>(house)));
        }
        [HttpPut]
        public async Task PutAsync([FromBody] HouseDtos house)
        {
            await _service.UpdateAsync(_mapper.Map<House>(house));
        }

        [HttpDelete("id/{id}")]
        public async Task DeleteAsync(int id)
        {
            await _service.DeleteAsync(await _service.GetByIdAsync(id));
        }

        [HttpDelete("userid/{userId}")]
        public async Task DeleteByUserIdAsync(int userId)
        {
            await _service.DeleteByUserIdAsync(userId);
        }

        [HttpDelete("username/{userName}")]
        public async Task DeleteByUserNameAsync(string userName)
        {
            await _service.DeleteByUserNameAsync(userName);
        }
    }
}
