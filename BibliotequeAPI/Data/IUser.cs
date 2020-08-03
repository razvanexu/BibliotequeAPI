using BibliotequeAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotequeAPI.Data
{
    interface IUser
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int userId);
    }
}
