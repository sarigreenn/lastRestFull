
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using restful.Models;
using restFul.Entities;
using restfull.core.DTOs;
using restfull.core.Repositories;
using restfull.core.Services;
using restfull.service;
using RestFull.Entities;
using System.Collections.Generic;

namespace RestFull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : Controller
    {
        private readonly IGuestService  _guestService;
        private readonly IMapper _mapping;

        public GuestController(IGuestService DC, IMapper _mapper)
        {
           _guestService = DC;
            _mapping = _mapper;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IActionResult> Get() {
            //var list = await _guestService.GetGuestsAsync();
            //var listDTo = _mapping.Map<IEnumerable<GuestDTO>>(list);
            //return Ok(listDTo);
            return Ok(_mapping.Map<IEnumerable<GuestDTO>>(await _guestService.GetGuestsAsync()));
        }
       
        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task< IActionResult> Get(int id)
        {
            var guest = _guestService.GetByIdAsync(id);
            var guestDTO=_mapping.Map<GuestDTO>(guest);
            if (guest == null)
            {
                return NotFound();
            }

            return Ok(guestDTO);
        }
       
        // POST api/<ValuesController>
        [HttpPost]
        public async  Task < ActionResult> Post([FromBody] GuestPostModel value)

        {
        
            var guest = _mapping.Map<Guest>(value);
            var guest1 = await _guestService.AddAsync(guest);
            return Ok(guest1);
        }
       

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task <ActionResult> Put(int id, [FromBody] GuestPostModel value)
        {
            //var guest =_mapping.Map<Guest>(value);
            //var x = await _guestService.GetByIdAsync(id);
            //if (x == null)
            //{
            //    return NotFound();
            //}
            //return Ok(await _guestService.UpdateAsync(id,value));
            var guest = _mapping.Map<Guest>(value);
            var x = await _guestService.GetByIdAsync(id);
            //var guest = _mapping.Map<Guest>(value);
            //var x = await guestService.GetByIdAsync(id);
            return Ok(await _guestService.UpdateAsync(id, guest));
        }
       //check
        //[HttpPut("{id}/status")]
        //public async Task<ActionResult<Guest>> Put(int id, [FromBody] Guest guest)
        //{
        //    //find the object by id
        //    var x =await _guestService.GetGuestsAsync().Find(id);
        //    //udpate properties
        //    //eve.Title = updateEvent.Title;
        //    return Ok(await _guestService.UpdateAsync(id, guest));
        //}

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {

            var x = _guestService.GetByIdAsync(id);
            if (x == null)
            {
                NotFound();
            }
            else await _guestService.DeleteAsync(id);
        }
       
    }
}
