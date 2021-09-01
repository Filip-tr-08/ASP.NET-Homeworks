using BookLibraryApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryApp.DataAccess.Interfaces
{
    public interface IBookRepository :IRepository<Book>
    {
       List<Book> GetBooksOnPromotion();

    }
}
