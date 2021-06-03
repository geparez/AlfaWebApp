using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Alfa.Models;

namespace Alfa.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Alfa.Models.Location> Location { get; set; }
        public DbSet<Alfa.Models.ScreenType> Screen { get; set; }
        public DbSet<Alfa.Models.ScreenLocation> ScreenLocation { get; set; }
    }
}
