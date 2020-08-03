using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotequeAPI.Model
{
    public class Transaction
    {
        public string AuthToken { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowTime { get; set; }
    }
}
