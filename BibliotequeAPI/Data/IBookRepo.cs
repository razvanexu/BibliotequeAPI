using BibliotequeAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotequeAPI.Data
{
    public interface IBookRepo
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int bookId);
    }
}
