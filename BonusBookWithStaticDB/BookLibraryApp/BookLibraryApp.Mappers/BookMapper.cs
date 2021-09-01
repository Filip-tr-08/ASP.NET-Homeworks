using BookLibraryApp.Domain.Models;
using BookLibraryApp.ViewModels.BookViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryApp.Mappers
{
   public static class BookMapper
    {
        public static BookDDViewModel BookToBookDDViewModel(this Book book)
        {
            return new BookDDViewModel
            {
                Id = book.Id,
                Title = book.Title
            };
        }
        public static BookDetailsViewModel BookToBookDetailsViewModel(this Book book)
        {
            return new BookDetailsViewModel
            {
                Id=book.Id,
                Title = book.Title,
                Genre = book.Genre,
                AuthorName = $"{book.Author.FirstName} {book.Author.LastName}",
                ImageLink=book.ImageLink,
                IsOnPromotion=book.IsOnPromotion?"✅": "❌",
                Pages=book.Pages,
                Price=book.Price,
                BookContent=book.BookContent
            };
        }
        public static BookListViewModel BookToBookListViewModel(this Book book)
        {
            return new BookListViewModel
            {
                Id=book.Id,
                Title=book.Title,
                Genre=book.Genre,
                IsOnPromotion=book.IsOnPromotion,
                Price=book.Price
            };
        }
        public static Book BookViewModelToBook(this BookViewModel bookViewModel)
        {
            return new Book
            {
                Title=bookViewModel.Title,
                Genre=bookViewModel.Genre,
                Author=bookViewModel.Author,
                IsOnPromotion=bookViewModel.IsOnPromotion,
                Pages=bookViewModel.Pages,
                Price=bookViewModel.Price,
                ImageLink=bookViewModel.ImageLink,
                BookContent=bookViewModel.BookContent,
            };
        }
        public static BookViewModel BookToBookViewModel(this Book book)
        {
            return new BookViewModel
            {
                Id=book.Id,
                Title = book.Title,
                Genre = book.Genre,
                Author = book.Author,
                IsOnPromotion = book.IsOnPromotion,
                Pages = book.Pages,
                Price = book.Price,
                ImageLink = book.ImageLink,
                BookContent = book.BookContent
            };
        }
    }
}
