using CreateApi;
using Microsoft.EntityFrameworkCore;
using restFul.Entities;
using restfull.core.Entities;
using restfull.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restfull.data.Repository
{
    public class InvetationRepository:IInvetationRepository
    {
        private readonly DataContext _context;

        public InvetationRepository(DataContext dataContext)
        {
            _context = dataContext;
        }

      

       

        public async Task<Invetation> AddInvetationAsync(Invetation invetation)
        {
            _context.Invetations.Add(invetation);
            await _context.SaveChangesAsync();
            return invetation;
        }

        public async Task DeleteInvetationAsync(int id)
        {
            var invetation = await GetByIdAsync(id);
            _context.Invetations.Remove(invetation);
            await _context.SaveChangesAsync();
        }



        public async Task<Invetation> GetByIdAsync(int id)
        {
            return await _context.Invetations.FindAsync(id);
        }

        public async Task<IEnumerable<Invetation>> GetAllInvetationsAsync()
        {
            return await _context.Invetations.ToListAsync();

        }



        public async Task<Invetation> UpdateInvetationAsync(int id, Invetation invetation)
        {
            var updateInvetation = await GetByIdAsync(id);
            if (updateInvetation != null)
            {
                updateInvetation.Id = invetation.Id;
                updateInvetation.DateTime = invetation.DateTime;
              
                _context.SaveChangesAsync();
            }
            return updateInvetation;
        }


    }
}
