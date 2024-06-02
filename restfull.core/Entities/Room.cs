using restFul.Entities;

namespace RestFull.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public bool Avialable { get; set; }
        public int GuestId { get; set; }
        public Guest Guest { get; set; }
    }
}
