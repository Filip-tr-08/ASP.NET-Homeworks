using BookLibraryApp.ViewModels.AuthorViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryApp.Services.Interfaces
{
    public interface IAuthorServices
    {
        List<AuthorDDViewModel> GetAuthorsForDropDown();
        public List<AuthorListViewModel> GetAuthorsList();
        AuthorDetailsViewModel GetAuthor(int id);
        void CreateAuthor(AuthorViewModel authorViewModel);
        AuthorViewModel GetAuthorForEditing(int id);
        void EditAuthor(AuthorViewModel authorViewModel);
        void DeleteAuthor(int id);
    }
}
