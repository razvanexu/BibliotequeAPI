using BibliotequeAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotequeAPI.Data
{
    public class MockBookRepo : IBookRepo
    {
        public IEnumerable<BookModel> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public BookModel GetBookById(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
