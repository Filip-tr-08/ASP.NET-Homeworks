using BookLibraryApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookLibraryApp.ViewModels.ReservationViewModel
{
    public class BookReservationViewModel
    {
        public int ReservationId{get;set;}
        [Display(Name ="Book")]
        public int BookId { get; set; }
        [Display(Name ="Genre")]
        public Genre BookGenre { get; set; }

    }
}
