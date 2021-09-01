using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookLibraryApp.ViewModels.MemberViewModel
{
   public class MemberViewModel
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Age")]
        public int Age { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Joined on")]
        public DateTime DateJoined { get; set; }
    }
}
