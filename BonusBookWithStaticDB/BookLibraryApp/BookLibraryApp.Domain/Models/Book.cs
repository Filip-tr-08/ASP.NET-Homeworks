using BookLibraryApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryApp.Domain.Models
{
   public class Book:BaseEntity
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public  int AuthorId { get; set; }
        public int Pages { get; set; }
        public Genre Genre { get; set; }
        public List<BookReservation> BookReservations { get; set; }
        public int Price { get; set; }
        public bool IsOnPromotion { get; set; }
        public string ImageLink { get; set; }
        public string BookContent { get; set; }
    }
}
