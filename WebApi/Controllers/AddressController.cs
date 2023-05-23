using AutoMapper;
using Entities.DTOs;
using Entities.Models;
using Entities.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class AddressController : Controller
    {

        private IAddressService _service;
        private IMapper _mapper;
        public AddressController(IAddressService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<AddressDtos>> GetAllAsync()
        {
            return _mapper.Map<List<AddressDtos>>(await _service.GetAllAsync());
        }


        [HttpGet("id/{id}")]
        public async Task<AddressDtos> GetByIdAsync(int id)
        {
            return _mapper.Map<AddressDtos>(await _service.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<AddressDtos> PostAsync([FromBody] AddressDtos address)
        {
            return _mapper.Map<AddressDtos>(await _service.CreateAsync(_mapper.Map<Address>(address)));
        }

        [HttpPut]
        public async Task PutAsync([FromBody] AddressDtos address)
        {
            await _service.UpdateAsync(_mapper.Map<Address>(address));
        }

        [HttpDelete("id/{id}")]
        public async Task DeleteById(int id)
        {
           await _service.DeleteAsync(await _service.GetByIdAsync(id));    
        }
    }
}
