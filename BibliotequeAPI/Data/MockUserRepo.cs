using BibliotequeAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotequeAPI.Data
{
    public class MockUserRepo : IUserRepo
    {
        public IEnumerable<User> GetAllUsers()
        {
            var users = new List<User>
            {
                new User { UserId = 0, FirstName = "Adriano", LastName = "Celentano", Password = "1234", Type = "Admin" },
                new User { UserId = 1, FirstName = "Al", LastName = "Bano", Password = "4321", Type = "Admin" },
                new User { UserId = 2, FirstName = "Romina", LastName = "Power", Password = "1235", Type = "Admin" }
            };
            return users;
        }

        public User GetUserById(int userId)
        {
            return new User { UserId = 0, FirstName = "Adriano", LastName = "Celentano", Password = "1234", Type = "Admin" };
        }
    }
}
