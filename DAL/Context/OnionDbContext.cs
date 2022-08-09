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
    public class OnionDbContext : IdentityDbContext<User,Role,Guid>
    {

        public OnionDbContext(DbContextOptions<OnionDbContext> options)
            :base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<Image> Images { get; set; }
        public DbSet<Message> Messages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(c => c.Image)
                .WithOne(c => c.User)
                .HasForeignKey<Image>(c => c.UserId);

            modelBuilder.Entity<Message>()
                .HasOne(c => c.ToUser)
                .WithMany(c => c.SentMessages)
                .HasForeignKey(c => c.ToUserId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message>()
                .HasOne(c => c.FromUser)
                .WithMany(c => c.ReceivedMessages)
                .HasForeignKey(c => c.FromUserId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.IncertUsersAndRoles();
            base.OnModelCreating(modelBuilder);
        }

    }
}
