using BibliotequeAPI.Data.Context;
using BibliotequeAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotequeAPI.Data
{
    public class SQLUserRepo : IUserRepo
    {
        private readonly UserContext _context;

        public SQLUserRepo(UserContext context)
        {
            _context = context;
        }

        IEnumerable<UserModel> IUserRepo.GetAllUsers()
        {
            return _context.Users.ToList();
        }

        UserModel IUserRepo.GetUserById(int userId)
        {
            return _context.Users.FirstOrDefault(p => p.UserId == userId );
        }
    }
}
