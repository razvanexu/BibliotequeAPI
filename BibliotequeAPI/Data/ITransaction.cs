﻿using BibliotequeAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotequeAPI.Data
{
    interface ITransaction
    {
        IEnumerable<Transaction> GetAllTransactions();
        Transaction GetTransactionById(int transactionId);
    }
}