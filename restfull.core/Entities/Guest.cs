using RestFull.Entities;

namespace restFul.Entities
{
    public class Guest
    {
        public int Id { get; set; }
        public int Phone { get; set; }
        public bool Status { get; set; }
        public Room Room { get; set; }
    }
}
