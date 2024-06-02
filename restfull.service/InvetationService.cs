using restFul.Entities;
using restfull.core.Entities;
using restfull.core.Repositories;
using restfull.core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restfull.service
{
    public class InvetationService:IInvetationSrevice
    {
        private readonly IInvetationRepository _invetationRepository;

        public InvetationService(IInvetationRepository _invetationRepository)
        {
            _invetationRepository = _invetationRepository;
        }

        public async Task<IEnumerable<Invetation>> GetInvetationsAsync()
        {

            return await _invetationRepository.GetAllInvetationsAsync();
        }
        public async Task<Invetation> GetByIdAsync(int id)
        {
            return await _invetationRepository.GetByIdAsync(id);
        }
        public async Task<Invetation> AddAsync(Invetation invetation)
        {
            //logic
            return await _invetationRepository.AddInvetationAsync(invetation);
        }
        public async Task<Invetation> UpdateAsync(int id, Invetation invetation)
        {
            return await _invetationRepository.UpdateInvetationAsync(id, invetation);
        }
        public async Task DeleteAsync(int id)
        {
            await _invetationRepository.DeleteInvetationAsync(id);
        }

    }
}
