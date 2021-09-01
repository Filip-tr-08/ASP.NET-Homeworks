using BookLibraryApp.DataAccess.Interfaces;
using BookLibraryApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLibraryApp.DataAccess.Implementations
{
    public class BookRepository : IBookRepository
    {
        public void Delete(int id)
        {
            Book bookDb = StaticDb.Books.FirstOrDefault(x => x.Id == id);
            if (bookDb == null)
            {
                throw new Exception($"Book with id {id} not found");
            }
            StaticDb.Books.Remove(bookDb);
            int authorIndex = bookDb.Author.Id - 1;
            Book bookAuthor = StaticDb.Authors[authorIndex].Books.FirstOrDefault(x => x.Id == id);
            StaticDb.Authors[authorIndex].Books.Remove(bookAuthor);
        }

        public List<Book> GetAll()
        {
            return StaticDb.Books;
        }

        public List<Book> GetBooksOnPromotion()
        {
            return StaticDb.Books.Where(x => x.IsOnPromotion == true).ToList();
        }

        public Book GetById(int id)
        {
            return StaticDb.Books.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Book entity)
        {
            entity.Id = ++StaticDb.BookId;
            StaticDb.Books.Add(entity);
            int authorIndex = entity.Author.Id - 1;
            StaticDb.Authors[authorIndex].Books.Add(entity);
            return entity.Id;
        }

        public void Update(Book entity)
        {
            Book bookDb = StaticDb.Books.FirstOrDefault(x => x.Id == entity.Id);
            if (bookDb == null)
            {
                throw new Exception($"Book with id {entity.Id} not found");
            }
            if (bookDb.AuthorId != entity.AuthorId)
            {
                int oldAuthorIndex = bookDb.Author.Id - 1;
                Book bookAuthor = StaticDb.Authors[oldAuthorIndex].Books.FirstOrDefault(x => x.Id == entity.Id);
                StaticDb.Authors[oldAuthorIndex].Books.Remove(bookAuthor);
                int newAuthorIndex = entity.Author.Id - 1;
                StaticDb.Authors[newAuthorIndex].Books.Add(entity);
            }
            int index = StaticDb.Books.IndexOf(bookDb);
            StaticDb.Books[index] = entity;
        }
    }
}
