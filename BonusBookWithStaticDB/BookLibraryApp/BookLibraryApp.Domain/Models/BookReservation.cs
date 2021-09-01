using BookLibraryApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryApp.Domain.Models
{
    public class BookReservation : BaseEntity
    {
        public Book Book { get; set; }
        public int BookId { get; set; }
        public Reservation Reservation { get; set; }
        public int ReservationId { get; set; }
        public Genre BookGenre { get; set; }
    }
}
