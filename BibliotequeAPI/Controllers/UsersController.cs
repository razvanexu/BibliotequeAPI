using AutoMapper;
using BibliotequeAPI.Data;
using BibliotequeAPI.DTO;
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
        private readonly IMapper _userMapper;

        public UsersController(IUserRepo usersRepo, IMapper userMapper)
        {
            _usersRepo = usersRepo;
            _userMapper = userMapper;
        }

        //GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<UserReadDTO>> GetAllUsers()
        {
            var userItems = _usersRepo.GetAllUsers();
            return Ok(_userMapper.Map<IEnumerable<UserReadDTO>>(userItems));
        }

        //GET api/users/{id}
        [HttpGet("{id}", Name = "GetUserById")]
        public ActionResult<UserReadDTO>GetUserById(int id)
        {
            var userItem = _usersRepo.GetUserById(id); 
            if(userItem != null)
            {
                return Ok(_userMapper.Map<UserReadDTO>(userItem));
            }
            return NotFound();
        }

        //POST/api/users
        [HttpPost]
        public ActionResult<UserReadDTO> CreateUser(UserCreateDTO createUserDTO)
        {
            var userModel = _userMapper.Map<UserModel>(createUserDTO);
            _usersRepo.CreateUser(userModel);
            _usersRepo.SaveChanges();
            var userReadDTO = _userMapper.Map<UserReadDTO>(userModel);

            return CreatedAtRoute(nameof(GetUserById), new { id = userReadDTO.UserId }, userReadDTO);
        }



        //PUT/users{id}
        [HttpPut("{id}")]
        public ActionResult UpdateUser(int id, UserUpdateDTO userUpdateDTO)
        {
            var userModelFromRepo = _usersRepo.GetUserById(id);
            if(userModelFromRepo == null)
            {
                return NotFound();
            }

            _userMapper.Map(userUpdateDTO, userModelFromRepo);
            _usersRepo.UpdateUser(userModelFromRepo);
            _usersRepo.SaveChanges();

            return NoContent();
        }
    }
}
