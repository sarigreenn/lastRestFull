using restFul.Entities;
using restfull.core.Repositories;
using restfull.core.Services;

namespace restfull.service
{
    public class GuestService: IGuestService
    {
        private readonly IGeuestRepository _guestRepository;

        public GuestService(IGeuestRepository guestRepository)
        {
            _guestRepository = guestRepository;
        }

        public async  Task< IEnumerable<Guest> > GetGuestsAsync()
        {
          
            return await _guestRepository.GetAllGeustsAsync();
        }
        public async Task< Guest> GetByIdAsync(int id)
        {
            return await _guestRepository.GetByIdAsync(id);
        }
        public async Task< Guest> AddAsync(Guest guest)
        {
            //logic
            return await _guestRepository.AddGuestAsync(guest);
        }
        public async Task< Guest> UpdateAsync(int id,Guest guest)
        {
            return await _guestRepository.UpdateGuestAsync(id, guest);
        }
        public async Task DeleteAsync(int id)
        {
             await _guestRepository.DeleteGuestAsync(id);
        }

      
    }
   
}