using AutoMapper;
using BibliotequeAPI.Data;
using BibliotequeAPI.DTO.Books;
using BibliotequeAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotequeAPI.Controllers
{
    //api/books (dynamic allocated name)
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepo _booksRepo;
        private readonly IMapper _bookMapper;

        public BooksController(IBookRepo booksRepo, IMapper bookMapper)
        {
            _booksRepo = booksRepo;
            _bookMapper = bookMapper;
        }

        //GET api/books
        [HttpGet]
        public ActionResult<IEnumerable<BookReadDTO>> GetAllBooks()
        {
            var bookItems = _booksRepo.GetAllBooks();
            return Ok(_bookMapper.Map<IEnumerable<BookReadDTO>>(bookItems));
        }

        //GET api/books/{id}
        [HttpGet("{id}", Name = "GetBookById")]
        public ActionResult<BookReadDTO> GetBookById(int id)
        {
            var bookItem = _booksRepo.GetBookById(id);
            if (bookItem != null)
            {
                return Ok(_bookMapper.Map<BookReadDTO>(bookItem));
            }
            return NotFound();
        }

        //POST/api/books
        [HttpPost]
        public ActionResult<BookReadDTO> CreateBook(BookCreateDTO createBookDTO)
        {
            var bookModel = _bookMapper.Map<BookModel>(createBookDTO);
            _booksRepo.CreateBook(bookModel);
            _booksRepo.SaveChanges();
            var bookReadDTO = _bookMapper.Map<BookReadDTO>(bookModel);

            return CreatedAtRoute(nameof(GetBookById), new { id = bookReadDTO.BookId }, bookReadDTO);
        }



        
    }
}
