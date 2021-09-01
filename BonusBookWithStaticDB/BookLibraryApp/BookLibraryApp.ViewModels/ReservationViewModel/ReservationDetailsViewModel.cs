using BookLibraryApp.Domain.Enums;
using BookLibraryApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookLibraryApp.ViewModels.ReservationViewModel
{
    public class ReservationDetailsViewModel
    {
        public int Id { get; set; }
        [Display(Name ="Payment method")]
        public PaymentMethod PaymentMethod { get; set; }
        public string ReservationMethod { get; set; }
        [Display(Name ="Reservation Start")]
        public DateTime DateTimeBegin { get; set; }
        [Display(Name ="Reservation End")]
        public DateTime DateTimeEnd { get; set; }
        [Display(Name ="Member")]
        public string MemberFullName { get; set; }
        [Display(Name ="Books")]
        public List<Book> Books { get; set; }
        //public List<string> BookTitles { get; set; }
    }
}
