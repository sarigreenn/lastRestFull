using restFul.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restfull.core.Repositories
{
    public interface IGeuestRepository
    {
       Task< IEnumerable<Guest>> GetAllGeustsAsync();
      Task<  Guest> GetByIdAsync(int id);

      Task<  Guest> AddGuestAsync(Guest guest);

       Task< Guest> UpdateGuestAsync(int id, Guest guest);

        Task DeleteGuestAsync(int id);

    }
}
