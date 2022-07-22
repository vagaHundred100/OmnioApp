using DAL.Context.SeedData;
using DAL.Domains;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    //IdentityRole default identiti - nin classidir 
    //string hamsinin id-si stringdir
    public class OnionDbContext : IdentityDbContext<User>
    {
        public OnionDbContext(DbContextOptions<OnionDbContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.IncertUsersAndRoles();
            base.OnModelCreating(builder);
        }

    }
}
