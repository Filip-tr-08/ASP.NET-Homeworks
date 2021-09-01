using BookLibraryApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookLibraryApp.ViewModels.AuthorViewModel
{
    public class AuthorDetailsViewModel
    {
        public int Id { get; set; }
        [Display(Name ="Full Name")]
        public string FullName { get; set; }
        
        [Display(Name ="Nationality")]
        public string Nationality { get; set; }
        [Display(Name ="Image")]
        public string ImageLink { get; set; }
        public string Biography { get; set; }
        public List<Book> Books { get; set; }
    }
}
