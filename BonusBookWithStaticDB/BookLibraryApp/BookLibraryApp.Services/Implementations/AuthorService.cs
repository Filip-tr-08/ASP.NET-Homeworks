using BookLibraryApp.DataAccess.Interfaces;
using BookLibraryApp.Domain.Models;
using BookLibraryApp.Mappers;
using BookLibraryApp.Services.Interfaces;
using BookLibraryApp.ViewModels.AuthorViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLibraryApp.Services.Implementations
{
   public class AuthorService: IAuthorServices
    {
        private IRepository<Author> _authorRepository;
        public AuthorService(IRepository<Author> authorRepository)
        {
            _authorRepository = authorRepository;
        }
        
        public List<AuthorDDViewModel> GetAuthorsForDropDown()
        {
            List<Author> authorsDb = _authorRepository.GetAll();
            return authorsDb.Select(x => x.AuthorToAuthorDDViewModel()).ToList();
        }
        public List<AuthorListViewModel> GetAuthorsList()
        {
            List<Author> authorsDb = _authorRepository.GetAll();
            return authorsDb.Select(x => x.AuthorToAuthorListViewModel()).ToList();
        }
        public AuthorDetailsViewModel GetAuthor(int id)
        {
            Author author = _authorRepository.GetById(id);
            if (author == null)
            {
                throw new Exception($"Author with id {id} was not found");
            }
            return author.AuthorToAuthorDetailsViewModel();
        }
        public void CreateAuthor(AuthorViewModel authorViewModel)
        {
            Author authorDb = authorViewModel.AuthorViewModelToAuthor();
            int newAuthorId = _authorRepository.Insert(authorDb);
            if (newAuthorId <= 0)
            {
                throw new Exception("An error had occured while saving in db");
            }
        }
        public AuthorViewModel GetAuthorForEditing(int id)
        {
            Author authorDb = _authorRepository.GetById(id);
            if (authorDb == null)
            {
                throw new Exception($"The author with id {id} was not found");
            }
            return authorDb.AuthorToAuthorViewModel();
        }
        public void EditAuthor(AuthorViewModel authorViewModel)
        {
            Author author = _authorRepository.GetById(authorViewModel.Id);
            if (author == null)
            {
                throw new Exception($"The author with id {authorViewModel.Id} was not found");
            }
           
            Author editedAuthor = authorViewModel.AuthorViewModelToAuthor();
            editedAuthor.Id = authorViewModel.Id; ;
            _authorRepository.Update(editedAuthor);
        }
        public void DeleteAuthor(int id)
        {
            Author authorDb = _authorRepository.GetById(id);
            if (authorDb == null)
            {
                throw new Exception($"The author with id {id} was not found");
            }
            _authorRepository.Delete(id);
        }
    }
}
