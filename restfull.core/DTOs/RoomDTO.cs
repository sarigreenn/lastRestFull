using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restfull.core.DTOs
{
    public class RoomDTO
    {
        public int Id { get; set; }
        public bool Avialable { get; set; }
        public int GuestId { get; set; }

    }
}
