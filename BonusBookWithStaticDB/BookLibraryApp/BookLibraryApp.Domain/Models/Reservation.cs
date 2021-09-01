using BookLibraryApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryApp.Domain.Models
{
    public class Reservation:BaseEntity
    {
       public PaymentMethod PaymentMethod { get; set; }
       public ReservationMethod ReservationMethod { get; set; }
       public List<BookReservation> BookReservations { get; set; }
       public DateTime DateTimeBegin { get; set; }
       public DateTime DateTimeEnd { get; set; }
       public Member Member { get; set; }
       public int MemberId { get; set; }
        
    }
}
