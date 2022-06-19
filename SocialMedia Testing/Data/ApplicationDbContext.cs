using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMedia_Testing.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public static object SocialMedia { get; internal set; }
        public DbSet<SocialMedia_Testing.Models.Users> Users { get; set; }
        public DbSet<SocialMedia_Testing.Models.Users> Post { get; set; }

    }
}
