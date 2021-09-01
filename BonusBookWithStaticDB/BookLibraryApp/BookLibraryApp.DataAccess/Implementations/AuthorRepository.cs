using BookLibraryApp.DataAccess.Interfaces;
using BookLibraryApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLibraryApp.DataAccess.Implementations
{
    public class AuthorRepository : IRepository<Author>
    {
        public void Delete(int id)
        {
            Author authorDb = StaticDb.Authors.FirstOrDefault(x => x.Id == id);
            if (authorDb == null)
            {
                throw new Exception($"Author with id {id} not found");
            }
            StaticDb.Authors.Remove(authorDb);
        }

        public List<Author> GetAll()
        {
            return StaticDb.Authors;
        }

        public Author GetById(int id)
        {
            return StaticDb.Authors.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Author entity)
        {
            entity.Id = ++StaticDb.AuthorId;
            entity.Books = new List<Book>();
            StaticDb.Authors.Add(entity);
            return entity.Id;
        }

        public void Update(Author entity)
        {
            Author authorDb = StaticDb.Authors.FirstOrDefault(x => x.Id == entity.Id);
            if (authorDb == null)
            {
                throw new Exception($"Author with id {entity.Id} not found");
            }
            int index = StaticDb.Authors.IndexOf(authorDb);
            StaticDb.Authors[index] = entity;
        }
    }
}
