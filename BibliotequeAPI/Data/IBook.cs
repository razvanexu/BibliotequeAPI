using BibliotequeAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotequeAPI.Data
{
    interface IBook
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int bookId);
    }
}
