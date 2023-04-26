using BLL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_GIT_TEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAll()
        {
            return Ok(_userService.GetAll());
        }


        [HttpGet("{id:int}")]
        public ActionResult<User> GetById(int id)
        {
            if (ModelState.IsValid)
            {
                User? user = _userService.GetById(id);
                return user is not null ? Ok(user) : BadRequest();
            }

            return BadRequest();
        }

        [HttpGet("{email}")]
        public ActionResult<User> GetByEmail(string email)
        {
            if (ModelState.IsValid)
            {
                User? user = _userService.GetByEmail(email);
                return user is not null ? Ok(user) : BadRequest();
            }

            return BadRequest();
        }


        [HttpPost]
        public ActionResult<User> Add(User user)
        {

            if (ModelState.IsValid)
            {
                User? userAdd = _userService.Add(user);
                return userAdd is not null ? Ok(userAdd) : Problem();
            }

            return BadRequest();

        }

        [HttpPut("{id}")]
        public ActionResult<User> UpdateProfil(int id)
        {

            if (ModelState.IsValid)
            {
                User? user = _userService.UpdateUser(id);
                return user is not null ? Ok(user) : BadRequest();
            }

            return BadRequest();
        }

    }
}
