using BibliotequeAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotequeAPI.Data
{
    public interface IUserRepo
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int userId);
    }
}
