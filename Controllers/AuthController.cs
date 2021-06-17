using System;
using El_Projekte_Grande.Dtos;
using El_Projekte_Grande.Helpers;
using El_Projekte_Grande.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace El_Projekte_Grande.Controllers
{
    [Route("api")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly JwtService _jwtService;

        public AuthController(IUserRepository userRepository,JwtService jwtService)
        {
            _userRepository = userRepository;
            _jwtService = jwtService;
        }
        
       [HttpPost("register")]
        public IActionResult Register(RegisterDto dto)
        {
            var user = new User 
            {
                Name = dto.Name,
                Email = dto.Email,
                Password = BCrypt.Net.BCrypt.HashPassword(dto.Password)
            };
           
            
            return Created("success",_userRepository.Create(user));
        }
        
        [HttpPost("login")]
        public IActionResult Login(LoginDto dto)
        {
            var user = _userRepository.GetByEmail(dto.Email);

            if (user == null) return BadRequest(new {message = "Invalid Credentials"});
            if (!BCrypt.Net.BCrypt.Verify(dto.Password, user.Password))
            {
                return BadRequest(new {message = "Invalid Credentials"});
            }

            var jwt = _jwtService.Generate(user.Id);
            Response.Cookies.Append("jwt",jwt, new CookieOptions
            {
                HttpOnly = true
            });
            
            return Ok(new
            {
                message ="success"
            });
        }
        
        [HttpGet("user")]
        public IActionResult User()
        {
            try 
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtService.Verify(jwt);
                int userId = int.Parse(token.Issuer);
                var user = _userRepository.GetById(userId);
                return Ok(user);


            }
            
            catch (Exception _) 
            {
                return Unauthorized();

            }
           
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
          Response.Cookies.Delete("jwt");

          return Ok(new 
          {
              message = "success"
          });
        }
    }
}