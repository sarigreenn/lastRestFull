using restFul.Entities;
using restfull.core.Repositories;
using restfull.core.Services;
using RestFull.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restfull.service
{
    public class RoomService:IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public async Task<IEnumerable<Room>> GetRoomsAsync()
        {
            return await _roomRepository.GetAllRoomsAsync();
        }
        public async Task< Room> GetByIdAsync(int id)
        {
            return await _roomRepository.GetByIdAsync(id);
        }
        public async Task< Room> AddAsync(Room room)
        {
            //logic
            return await _roomRepository.AddRoomAsync(room);
        }
        public async Task< Room> UpdateAsync(int id, Room room)
        {
            return await _roomRepository.UpdateRoomAsync(id, room);
        }
        public async Task DeleteAsync(int id)
        {
             await _roomRepository.DeleteRoomAsync(id);
        }

       
    }
}
