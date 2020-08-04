using BibliotequeAPI.Data;
using BibliotequeAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotequeAPI.Controllers
{   
    //api/users (dynamic allocated name)
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepo _usersRepo;

        public UsersController(IUserRepo usersRepo)
        {
            _usersRepo = usersRepo;
        }

        //private readonly MockUserRepo _usersRepo = new MockUserRepo();

        //GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            var userItems = _usersRepo.GetAllUsers();
            return Ok(userItems);
        }

        //GET api/users/{id}
        [HttpGet("{id}")]
        public ActionResult<User>GetUserById(int userId)
        {
            var userItems = _usersRepo.GetUserById(userId);
            return Ok(userItems);
        }
    }
}
