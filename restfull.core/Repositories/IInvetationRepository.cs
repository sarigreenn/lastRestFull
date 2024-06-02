using restFul.Entities;
using restfull.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restfull.core.Repositories
{
    public interface IInvetationRepository
    {
        Task<IEnumerable<Invetation>> GetAllInvetationsAsync();
        Task<Invetation> GetByIdAsync(int id);

        Task<Invetation> AddInvetationAsync(Invetation invetation);

        Task<Invetation> UpdateInvetationAsync(int id, Invetation invetation);

        Task DeleteInvetationAsync(int id);
    }
}
