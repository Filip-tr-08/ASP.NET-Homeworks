using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEDC.PizzaApp.ViewModels.FeedbackViewModels
{
   public class FeedbackViewModel
    {
        public int Id { get; set; }

        [Display (Name ="Visitor Name")]
        public string Name { get; set; }
        [Display(Name = "Visitor Email")]
        public string Email { get; set; }
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}
