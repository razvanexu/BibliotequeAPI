using BibliotequeAPI.Data.Context;
using BibliotequeAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotequeAPI.Data
{
    public class SQLBookRepo : IBookRepo
    {
        private readonly BibliotequeContext _context;

        public SQLBookRepo(BibliotequeContext context)
        {
            _context = context;
        }

        public void CreateBook(BookModel book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            _context.Add(book);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }


        IEnumerable<BookModel> IBookRepo.GetAllBooks()
        {
            return _context.Books.ToList();
        }

        BookModel IBookRepo.GetBookById(int bookId)
        {
            return _context.Books.FirstOrDefault(p => p.BookId == bookId);
        }
    }
}
