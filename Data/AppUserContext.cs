using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppUser.Entities;

    public class AppUserContext : DbContext
    {
        public AppUserContext (DbContextOptions<AppUserContext> options)
            : base(options)
        {
        }
        public DbSet<AppUser.Entities.User> User { get; set; }

        
    }
