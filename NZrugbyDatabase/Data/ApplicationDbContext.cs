using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using NZrugbyDatabase.Models;

namespace NZrugbyDatabase.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<NZrugbyDatabase.Models.Team> Team { get; set; }
        public DbSet<NZrugbyDatabase.Models.Manager> Manager { get; set; }
        public DbSet<NZrugbyDatabase.Models.Player> Player { get; set; }
    }
}
