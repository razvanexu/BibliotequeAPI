using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotequeAPI.DTO.Books
{
    public class BookCreateDTO
    {
        [Required]
        [MaxLength(150)]
        public string BookName { get; set; }

        [Required]
        [MaxLength(150)]
        public string BookAuthor { get; set; }

        [Required]
        [MaxLength]
        public string BookDescription { get; set; }
    }
}
