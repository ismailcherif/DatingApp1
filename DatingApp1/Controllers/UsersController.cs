using System;
using DatingApp1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DatingApp1.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp1.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
		{
           _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _context.Users.ToListAsync();

            
        }

        // api/user/"user id"
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
           return await _context.Users.FindAsync(id);
        }
    }
}

