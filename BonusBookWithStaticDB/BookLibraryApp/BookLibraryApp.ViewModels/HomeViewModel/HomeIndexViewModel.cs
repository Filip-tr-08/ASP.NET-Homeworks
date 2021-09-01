using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryApp.ViewModels.HomeViewModel
{
    public class HomeIndexViewModel
    {
        public int ReservationCount { get; set; }
        public List<string> BooksOnPromotion { get; set; }
    }
}
