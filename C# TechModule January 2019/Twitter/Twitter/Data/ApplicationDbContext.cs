using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SoftUniTwitter.Data;

namespace Twitter.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Tweet> Tweets { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
