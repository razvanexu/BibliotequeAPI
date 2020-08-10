using BibliotequeAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotequeAPI.Data
{
    public interface IUserRepo
    {
        bool SaveChanges();
        IEnumerable<UserModel> GetAllUsers();
        UserModel GetUserById(int userId);
        void CreateUser(UserModel user);
        void UpdateUser(UserModel user );
    }
}
