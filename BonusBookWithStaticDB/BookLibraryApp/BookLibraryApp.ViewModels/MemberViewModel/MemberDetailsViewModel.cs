using BookLibraryApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookLibraryApp.ViewModels.MemberViewModel
{
   public class MemberDetailsViewModel
    {
        public int Id { get; set; }
        [Display(Name ="Full Name")]
        public string FullName { get; set; }
        [Display(Name ="Age")]
        public int Age { get; set; }
        [Display(Name ="Address")]
        public string Address { get; set; }
        [Display(Name ="Joined on")]
        public DateTime DateJoined { get; set; }
        public List<Reservation> ReservationsPerMember { get; set; }
    }
}
