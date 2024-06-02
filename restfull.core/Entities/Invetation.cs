using restFul.Entities;
using RestFull.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restfull.core.Entities
{
    public class Invetation
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public Guest Guest { get; set; }
        public Room Room { get; set; }

    }
}
