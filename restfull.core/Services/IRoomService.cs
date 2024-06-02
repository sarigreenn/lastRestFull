using restFul.Entities;
using RestFull.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restfull.core.Services
{
    public interface IRoomService
    {
        Task<IEnumerable <Room> >GetRoomsAsync();
        Task<Room> GetByIdAsync(int id);

        Task<Room> AddAsync(Room room);

      Task<  Room> UpdateAsync(int id, Room room);

        Task DeleteAsync(int id);
    }
}
