using BLL.Interfaces;
using DAL.Models;
using DAL.Models.DTO;
using DAL.Models.ViewModel;
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
        public ActionResult<IEnumerable<UserVM>> GetAll()
        {
            return Ok(_userService.GetAll());
        }


        [HttpGet("{id:int}")]
        public ActionResult<UserVM> GetById(int id)
        {
            if (ModelState.IsValid)
            {
                UserVM? user = _userService.GetById(id);
                return user is not null ? Ok(user) : BadRequest();
            }

            return BadRequest();
        }

        [HttpGet("{email}")]
        public ActionResult<UserVM> GetByEmail(string email)
        {
            if (ModelState.IsValid)
            {
                UserVM? user = _userService.GetByEmail(email);
                return user is not null ? Ok(user) : BadRequest();
            }

            return BadRequest();
        }

        [HttpPost]
        public ActionResult<UserVM> Add(AddUserDTO user)
        {

            if (ModelState.IsValid)
            {
                UserVM? userAdd = _userService.Add(user);
                return userAdd is not null ? Ok(userAdd) : Problem();
            }

            return BadRequest();

        }

        [HttpPut("{id}")]
        public ActionResult<UserVM> UpdateProfil(UpdateUserDTO user, int id)
        {

            if (ModelState.IsValid)
            {
                UserVM? userUpdate = _userService.UpdateUser(user, id);
                return userUpdate is not null ? Ok(userUpdate) : BadRequest();
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _userService.Delete(id) ? Ok() : BadRequest();
        }

    }
}
