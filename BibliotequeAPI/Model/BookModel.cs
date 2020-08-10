using System.ComponentModel.DataAnnotations;

namespace BibliotequeAPI.Model
{
    public class BookModel
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [MaxLength(150)]
        public string BookName { get; set; }

        [Required]
        [MaxLength(150)]
        public string BookAuthor { get; set; }

        [Required]
        [MaxLength(500)]
        public string BookDescription { get; set; }
    }
}
