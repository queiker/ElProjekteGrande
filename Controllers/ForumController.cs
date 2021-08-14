using InvestorZone.Entities;
using InvestorZone.Exceptions;
using InvestorZone.Models;
using InvestorZone.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestorZone.Controllers
{
    [Route("api/forum")]
    [ApiController]
    public class ForumController : ControllerBase
    {

        private readonly IAccountService _accountService;
        private readonly UserDbContext _context;

        public ForumController(IAccountService accountService, UserDbContext context)
        {
            _accountService = accountService;
            _context = context;
        }

        [HttpGet("forum")]

        public ActionResult<IEnumerable<LoginDto>> GetAll()
        {
            var forum = _context.Forum.ToList();

            return Ok(forum);
        }

        [HttpGet("{id}")]

        public ActionResult<LoginDto> GetById([FromRoute] int id)
        {
            var forum = _context
                .Forum
                .FirstOrDefault(r => r.Id == id);

            return Ok(forum);
        }


        [HttpDelete("{id}")]

        public void Delete(int id)
        {
            var forum = _context
                .Forum
                .FirstOrDefault(r => r.Id == id);

            if (forum is null)
                throw new NotFoundException("User not found");

            _context.Forum.Remove(forum);
            _context.SaveChanges();

        }

    }
}
