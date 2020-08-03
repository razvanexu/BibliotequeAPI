using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotequeAPI.Model
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowTime { get; set; }
    }
}
