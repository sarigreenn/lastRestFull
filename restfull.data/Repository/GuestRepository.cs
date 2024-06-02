using CreateApi;
using Microsoft.EntityFrameworkCore;
using restFul.Entities;
using restfull.core.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restfull.data.Repository
{
    public class GuestRepository : IGeuestRepository
    {
        private readonly DataContext _context;

        public GuestRepository(DataContext dataContext)
        {
            _context = dataContext;
        }

     
        public async Task< Guest> AddGuestAsync(Guest guest)
        {
            _context.guests.Add(guest);
          await  _context.SaveChangesAsync();
            return guest;
        }
       
        public async Task DeleteGuestAsync(int id)
        {
            var guest =await GetByIdAsync(id);
            _context.guests.Remove(guest);
         await _context.SaveChangesAsync();
        }

       

        public async Task< Guest> GetByIdAsync(int id)
        {
            return await _context.guests.FindAsync(id);
        }
        
        public async Task< IEnumerable<Guest>> GetAllGeustsAsync()
        {
            return await _context.guests.ToListAsync();
        }

       

        public async Task< Guest> UpdateGuestAsync(int id, Guest guest)
        {
            var updateGuest =await GetByIdAsync(id);
            if (updateGuest != null)
            {
                updateGuest.Id = guest.Id;
                updateGuest.Phone = guest.Phone;
                updateGuest.Status = guest.Status;


                 _context.SaveChangesAsync();
            }
            return  updateGuest;
        }

    }
}


 

  

