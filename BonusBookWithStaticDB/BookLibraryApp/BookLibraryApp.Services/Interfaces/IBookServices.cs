using BookLibraryApp.ViewModels.BookViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryApp.Services.Interfaces
{
    public interface IBookServices
    {
        List<BookDDViewModel> GetBooksForDropDown();
        public List<BookListViewModel> GetBooksList();
        BookDetailsViewModel GetBook(int id);
        void CreateBook(BookViewModel bookViewModel);
        BookViewModel GetBookForEditing(int id);
        void EditBook(BookViewModel bookViewModel);
        void DeleteBook(int id);
        List<string> GetBooksOnPromotion();
    }
}
