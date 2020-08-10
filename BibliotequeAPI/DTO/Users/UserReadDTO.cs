using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotequeAPI.DTO
{
    public class UserReadDTO
    {
        //[Key]
        public int UserId { get; set; }

        //[Required]
        //[MaxLength(100)]
        public string FirstName { get; set; }

        //[Required]
        //[MaxLength(100)]
        public string LastName { get; set; }

        //[Required]
        //[MaxLength(150)]
        public string Email { get; set; }

        //[Required]
        //[MaxLength(100)]
        public string Type { get; set; }
    }
}
