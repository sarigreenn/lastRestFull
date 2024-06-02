
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using restful.Controllers;
using restful.Models;
using restFul.Entities;
using restfull.core.DTOs;
using restfull.core.Services;
using restfull.service;
using RestFull.Entities;

namespace RestFull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : Controller
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapping;
        public RoomController(IRoomService DC ,IMapper mapper)
        {
            _roomService = DC;
            _mapping = mapper;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task< IActionResult> Get()
        {
            //var list = await _roomService.GetRoomsAsync();
            //var listDTo = _mapping.Map<IEnumerable<RoomDTO>>(list);
            //return Ok(listDTo);
            return Ok(_mapping.Map<IEnumerable<RoomDTO>>(await _roomService.GetRoomsAsync()));
        }
       


        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task< IActionResult> Get(int id)
        {
            var x = await _roomService.GetByIdAsync(id);
            var roomDTO = _mapping.Map<RoomDTO>(x);
            if (x == null)
            {
                return NotFound();
            }

            return Ok(roomDTO);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task< ActionResult> Post([FromBody] RoomPostModel value)
        {
            var room = _mapping.Map<Room>(value);
            var roomToAdd = await _roomService.AddAsync(room);
            return Ok(roomToAdd);
        }
        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task< ActionResult> Put(int id, [FromBody] RoomPostModel value)
        {
            var room = _mapping.Map<Room>(value);
            return Ok(await _roomService.UpdateAsync(id, room));
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task <ActionResult> Delete(int id)
        {
            var x = _roomService.GetByIdAsync(id);
            if (x == null)
            {
                NotFound();
            }
            await _roomService.DeleteAsync(id);
            return NoContent();
        }
    }
}








