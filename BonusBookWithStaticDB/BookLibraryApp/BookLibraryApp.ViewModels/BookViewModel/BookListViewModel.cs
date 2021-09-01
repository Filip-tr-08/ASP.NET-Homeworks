using BookLibraryApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryApp.ViewModels.BookViewModel
{
   public class BookListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Price { get; set; }
        public bool IsOnPromotion { get; set; }
    }
}
