using System;
using Microsoft.EntityFrameworkCore;
using DatingApp1.Entities;
namespace DatingApp1.Data
{
	public class DataContext : DbContext
	{
		

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}

