using CreateApi;
using Microsoft.EntityFrameworkCore;
using restFul.Entities;
using restfull.core.Repositories;
using RestFull.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restfull.data.Repository
{
    public class RoomRepository:IRoomRepository
    {
        private readonly DataContext _context;

        public RoomRepository(DataContext dataContext)
        {
            _context = dataContext;
        }


        public async Task< Room >AddRoomAsync(Room room)
        {
            _context.rooms.Add(room);
            await _context.SaveChangesAsync();
            return room;
        }

        public async Task DeleteRoomAsync(int id)
        {
            var room = await GetByIdAsync(id);
           _context.rooms.Remove(room);
            await _context.SaveChangesAsync();
        }

      

        public async  Task< Room> GetByIdAsync(int id)
        {
            return await _context.rooms.FindAsync(id);
        }
       
        public async Task< IEnumerable<Room>> GetAllRoomsAsync()
        {
            // return await _context.rooms.Include(u => u.GuestId).ToListAsync();
            return await _context.rooms.ToListAsync();
        }
      
        public async Task< Room> UpdateRoomAsync(int id, Room room)
        {
            var updateRoom =await GetByIdAsync(id);
            if (updateRoom != null)
            {
                updateRoom.Avialable = room.Avialable;
                updateRoom.Avialable = room.Avialable;
                await _context.SaveChangesAsync();
            }
            return updateRoom;
        }
      
    }
}
