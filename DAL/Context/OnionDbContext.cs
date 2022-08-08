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
        public DbSet<Image> Images { get; set; }

        public OnionDbContext(DbContextOptions<OnionDbContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(c => c.Image)
                .WithOne(c => c.User)
                .HasForeignKey<Image>(c => c.UserId);

            modelBuilder.IncertUsersAndRoles();
            base.OnModelCreating(modelBuilder);
        }

    }
}
