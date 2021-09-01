using BookLibraryApp.Domain.Enums;
using BookLibraryApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookLibraryApp.ViewModels.BookViewModel
{
    public class BookViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Display(Name = "Genre")]
        public Genre Genre { get; set; }
        [Display(Name = "Author")]
        public Author Author { get; set; }
        [Display(Name = "Total Pages")]
        public int Pages { get; set; }
        [Display(Name = "Is on Promotion")]
        public bool IsOnPromotion { get; set; }
        [Display(Name = "Price")]
        public int Price { get; set; }
        [Display(Name = "Image Link")]
        public string ImageLink { get; set; }
        [Display(Name ="Book Content")]
        public string BookContent { get; set; }
    }
}
