using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DynamicDashboard.Core.Entities;
using DynamicDashboard.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;

namespace DynamicDashboard.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MenuMaster> MenuMaster { get; set; }
    }
}
