using BookLibraryApp.Domain.Models;
using BookLibraryApp.ViewModels.AuthorViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryApp.Mappers
{
   public static class AuthorMapper
    {
        public static AuthorDDViewModel AuthorToAuthorDDViewModel(this Author author)
        {
            return new AuthorDDViewModel
            {
                Id = author.Id,
                AuthorFullName=$"{author.FirstName} {author.LastName}"
            };
        }
        public static AuthorDetailsViewModel AuthorToAuthorDetailsViewModel(this Author author)
        {
            return new AuthorDetailsViewModel
            {
                Id=author.Id,
                FullName = $"{author.FirstName} {author.LastName}",
                Nationality = author.Nationality,
                ImageLink = author.ImageLink,
                Biography=author.Biography,
                Books=author.Books,
            };
        }
        public static AuthorListViewModel AuthorToAuthorListViewModel(this Author author)
        {
            return new AuthorListViewModel
            {
                Id=author.Id,
                FullName =$"{author.FirstName} {author.LastName}",
                Nationality=author.Nationality
            };
        }
        public static Author AuthorViewModelToAuthor(this AuthorViewModel authorViewModel)
        {
            return new Author
            {
                FirstName=authorViewModel.FirstName,
                LastName=authorViewModel.LastName,
                Nationality=authorViewModel.Nationality,
                ImageLink=authorViewModel.ImageLink,
                Biography=authorViewModel.Biography,
                Books=authorViewModel.Books
            };
        }
        public static AuthorViewModel AuthorToAuthorViewModel(this Author author)
        {
            return new AuthorViewModel
            {
                Id=author.Id,
                FirstName=author.FirstName,
                LastName=author.LastName,
                Nationality=author.Nationality,
                Biography=author.Biography,
                ImageLink=author.ImageLink
            };
        }
    }
}
