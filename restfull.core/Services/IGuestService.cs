using restFul.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restfull.core.Services
{
    public interface IGuestService
    {
      Task < IEnumerable<Guest> > GetGuestsAsync();
      Task<  Guest> GetByIdAsync(int id);

        Task<Guest> AddAsync(Guest guest);

        Task<Guest> UpdateAsync(int id, Guest guest);

        Task DeleteAsync(int id);
    }
}
