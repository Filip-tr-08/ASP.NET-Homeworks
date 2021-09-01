using BookLibraryApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookLibraryApp.ViewModels.BookViewModel
{
   public class BookDetailsViewModel
    {
        public int Id { get; set; }
        [Display(Name ="Title")]
        public string Title { get; set; }
        [Display(Name = "Genre")]
        public Genre Genre { get; set; }
        [Display(Name ="Author")]
        public string AuthorName { get; set; }
        [Display(Name ="Total Pages")]
        public int Pages { get; set; }
        [Display(Name ="Is on Promotion")]
        public string IsOnPromotion { get; set; }
        [Display(Name ="Price")]
        public int Price { get; set; }
        [Display(Name = "Image")]
        public string ImageLink { get; set; }
        public string BookContent { get; set; }
        public int AuthorId { get; set; }


    }
    }
