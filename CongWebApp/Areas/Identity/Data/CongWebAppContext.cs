using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CongWebApp.Areas.Identity.Data;
using CongWebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CongWebApp.Data
{
    public class CongWebAppContext : IdentityDbContext<CongWebAppUser>
    {
        public CongWebAppContext(DbContextOptions<CongWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<Member> Member { get; set; }
        public DbSet<FieldServiceGroup> FieldServiceGroup { get; set; }
    
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Member>().ToTable("Member");
            builder.Entity<FieldServiceGroup>().ToTable("FieldServiceGroup");
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
