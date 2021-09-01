using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryApp.Domain.Models
{
    public class Member:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public DateTime DateJoined { get; set; }
        public List<Reservation> ReservationsPerMember { get; set; }
    }
}
