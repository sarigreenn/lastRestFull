using RestFull.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restfull.core.Repositories
{
    public interface IRoomRepository
    {
      Task<  IEnumerable<Room>> GetAllRoomsAsync();
     Task   <Room >GetByIdAsync(int id);

     Task  < Room> AddRoomAsync(Room room);

      Task<  Room> UpdateRoomAsync(int id, Room room);

        Task DeleteRoomAsync(int id);
    }
}
