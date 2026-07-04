using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.DTOs;
using WebApplication2.Interfaces;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly JwtService _jwtService;

        public UsersController(IUserService userService, JwtService jwtService)
        {
            _userService = userService;
            _jwtService = jwtService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           return Ok( await _userService.GetAll());
           
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _userService.GetById(id);

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserDto dto)
        {
            var created = await _userService.Create(dto);

            return CreatedAtAction(nameof(GetById),
                new { id = created.Id },
                created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id,  UpdateUserDto dto)
        {
            var result = await _userService.Update(id, dto);

            if (!result)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _userService.Delete(id);

            if (!result)
                return NotFound();

            return NoContent();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO dto)
        {
            var user = await _userService.Login(dto);

            if (user == null)
                return Unauthorized("Invalid credentials");

            var token = _jwtService.GenerateToken(user.Id, user.Email);

            return Ok(new
            {
                token
            });
        }

    }
}
