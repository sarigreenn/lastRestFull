using restFul.Entities;
using restfull.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restfull.core.Services
{
    public interface IInvetationSrevice
    {
        Task<IEnumerable<Invetation>> GetInvetationsAsync();
        Task<Invetation> GetByIdAsync(int id);

        Task<Invetation> AddAsync(Invetation invetation);

        Task<Invetation> UpdateAsync(int id, Invetation invetation);

        Task DeleteAsync(int id);
    }
}
