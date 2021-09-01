using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryApp.ViewModels.ReservationViewModel
{
    public class ReservationListViewModel
    {
        public int Id { get; set; }
        public string MemberFullName { get; set; }
        public DateTime DateTimeBegin { get; set; }
        public DateTime DateTimeEnd { get; set; }
        public List<string> BookTitles { get; set; }
        public string ReservationMethod { get; set; }
    }
}
