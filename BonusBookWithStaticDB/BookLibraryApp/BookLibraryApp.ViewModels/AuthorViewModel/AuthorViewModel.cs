using BookLibraryApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookLibraryApp.ViewModels.AuthorViewModel
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Nationality")]
        public string Nationality { get; set; }
        [Display(Name = "Image Link")]
        public string ImageLink { get; set; }
        [Display(Name ="Biography")]
        public string Biography { get; set; }
        public List<Book> Books { get; set; } 
    }
}
