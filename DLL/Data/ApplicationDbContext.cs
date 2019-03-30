using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bg_DAL.Models;

namespace Bg_DAL
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }

        public DbSet<PlayerData> Players { get; internal set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PlayerData>().HasKey(m => m.PlayerID);
            base.OnModelCreating(builder);
        }
    }
}
