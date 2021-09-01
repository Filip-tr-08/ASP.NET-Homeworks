using BookLibraryApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookLibraryApp.ViewModels.ReservationViewModel
{
    public class ReservationViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Payment method")]
        public PaymentMethod PaymentMethod { get; set; }
        [Display(Name = "Reservation method")]
        public ReservationMethod ReservationMethod { get; set; }
        [Display(Name = "Reservation Start")]
        public DateTime DateTimeBegin { get; set; }
        [Display(Name = "Reservation End")]
        public DateTime DateTimeEnd { get; set; }
        public List<string> BookTitles { get; set; }
        [Display(Name = "Book")]
        public int BookId { get; set; }
        [Display(Name = "Member")]
        public int MemberId { get; set; }

    }
}
