using BookLibraryApp.DataAccess.Interfaces;
using BookLibraryApp.Domain.Models;
using BookLibraryApp.Mappers;
using BookLibraryApp.Services.Interfaces;
using BookLibraryApp.ViewModels.BookViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLibraryApp.Services.Implementations
{
    public class BookService : IBookServices
    {
        private IBookRepository _bookRepository;
        private IRepository<Author> _authorRepository;
        public BookService(IBookRepository bookRepository, IRepository<Author> authorRepository)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
        }
        public void CreateBook(BookViewModel bookViewModel)
        {
            Author authorDb = _authorRepository.GetById(bookViewModel.Author.Id);
            if (authorDb == null)
            {
                throw new Exception($"Author with id {bookViewModel.Author.Id} was not found");
            }
            Book book = bookViewModel.BookViewModelToBook();
            book.Author = authorDb;
            int newBookId = _bookRepository.Insert(book);
            if (newBookId <= 0)
            {
                throw new Exception("An error occured while saving book in db");
            }
        }

        public BookDetailsViewModel GetBook(int id)
        {
            Book bookDb = _bookRepository.GetById(id);
            if (bookDb == null)
            {
                throw new Exception($"The book with id {id} was not found");
            }
            return bookDb.BookToBookDetailsViewModel();
        }

        public List<BookDDViewModel> GetBooksForDropDown()
        {
            List<Book> bookListViewModels = _bookRepository.GetAll();
            return bookListViewModels.Select(x => x.BookToBookDDViewModel()).ToList();
        }
        public List<string> GetBooksOnPromotion()
        {
            List<Book> books= _bookRepository.GetBooksOnPromotion();
            return books.Select(x => x.Title).ToList();
        }
        public List<BookListViewModel> GetBooksList()
        {
            List<Book> bookListViewModels = _bookRepository.GetAll();
            return bookListViewModels.Select(x => x.BookToBookListViewModel()).ToList();
        }
        public BookViewModel GetBookForEditing(int id)
        {
            Book bookDb = _bookRepository.GetById(id);
            if (bookDb == null)
            {
                throw new Exception($"The book with id {id} was not found");
            }
            return bookDb.BookToBookViewModel();
        }
        public void EditBook(BookViewModel bookViewModel)
        {
            Book book = _bookRepository.GetById(bookViewModel.Id);
            if (book == null)
            {
                throw new Exception($"The book with id {bookViewModel.Id} was not found");
            }
          
            Book editedBook = bookViewModel.BookViewModelToBook();
            
            editedBook.Id = bookViewModel.Id; ;
            
            _bookRepository.Update(editedBook);
        }
        public void DeleteBook(int id)
        {
            Book bookDb = _bookRepository.GetById(id);
            if (bookDb == null)
            {
                throw new Exception($"The book with id {id} was not found");
            }
            _bookRepository.Delete(id);
        }
    }
}
