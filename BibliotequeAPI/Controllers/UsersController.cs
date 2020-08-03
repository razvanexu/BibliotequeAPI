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
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {

        }

        [HttpGet]
        public ActionResult<User>GetUserById(int userId)
        {

        }
    }
}
