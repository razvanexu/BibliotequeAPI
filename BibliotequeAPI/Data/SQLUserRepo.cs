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
        private readonly BibliotequeContext _context;

        public SQLUserRepo(BibliotequeContext context)
        {
            _context = context;
        }

        public void CreateUser(UserModel user)
        {
            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            _context.Add(user);
        }

        public bool SaveChanges()
        {
           return (_context.SaveChanges() >= 0);
        }

        public void UpdateUser(UserModel user)
        {
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
