using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using restFul.Entities;
using restful.Models;
using restfull.core.DTOs;
using restfull.core.Services;
using restfull.service;
using restfull.core.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace restful.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvetationController : ControllerBase
    {

        private readonly IInvetationSrevice _invetationService;
        private readonly IMapper _mapping;
        public InvetationController(IInvetationSrevice DC, IMapper _mapper)
        {
            _invetationService = DC;
            _mapping = _mapper;
        }
        // GET: api/<InvetationController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var list = await _guestService.GetGuestsAsync();
            //var listDTo = _mapping.Map<IEnumerable<GuestDTO>>(list);
            //return Ok(listDTo);
            return Ok(_mapping.Map<IEnumerable<InvetationDTO>>(await _invetationService.GetInvetationsAsync()));
        }

        // GET api/<InvetationController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var invetation = _invetationService.GetByIdAsync(id);
            var invetationDTO = _mapping.Map<InvetationDTO>(invetation);
            if (invetation == null)
            {
                return NotFound();
            }

            return Ok(invetationDTO);
        }

        // POST api/<InvetationController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] InvetationPostModel value)

        {

            var invetation = _mapping.Map<Invetation>(value);
            var invetation1 = await _invetationService.AddAsync(invetation);
            return Ok(invetation1);
        }

        // PUT api/<InvetationController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] InvetationPostModel value)
        {
            //var guest =_mapping.Map<Guest>(value);
            //var x = await _guestService.GetByIdAsync(id);
            //if (x == null)
            //{
            //    return NotFound();
            //}
            //return Ok(await _guestService.UpdateAsync(id,value));
            var invetation = _mapping.Map<Invetation>(value);
            var x = await _invetationService.GetByIdAsync(id);
            //var guest = _mapping.Map<Guest>(value);
            //var x = await guestService.GetByIdAsync(id);
            return Ok(await _invetationService.UpdateAsync(id, invetation));
        }

        // DELETE api/<InvetationController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {

            var x = _invetationService.GetByIdAsync(id);
            if (x == null)
            {
                NotFound();
            }
            else await _invetationService.DeleteAsync(id);
        }
    }
}
