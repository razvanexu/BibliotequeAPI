using BibliotequeAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotequeAPI.Data
{
    public interface IBookRepo
    {
        bool SaveChanges();
        IEnumerable<BookModel> GetAllBooks();
        BookModel GetBookById(int bookId);
        void CreateBook(BookModel book);
        //void BulkBooks(List<BookModel> books);
    }
}
