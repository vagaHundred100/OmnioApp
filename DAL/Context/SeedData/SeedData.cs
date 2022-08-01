using DAL.Domains;
using Microsoft.EntityFrameworkCore;
using BCryptNet = BCrypt.Net.BCrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DAL.Context.SeedData
{
    public static class SeedData
    {
        public static void IncertUsersAndRoles(this ModelBuilder modelBuilder)
        {
            User user = new User()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "Admin",
                Email = "admin@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890",
                NormalizedUserName = "ADMIN"
            };

            User user2 = new User()
            {
                Id = "29948c14-7554-434e-9772-5e6714faca71",
                UserName = "user",
                Email = "vaga@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890",
                NormalizedUserName = "USER"
            };

            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            var hashedPass = passwordHasher.HashPassword(user, "vaga100Akif1998@");
            user.PasswordHash = hashedPass;
            modelBuilder.Entity<User>().HasData(user);

            var hashedPass2 = passwordHasher.HashPassword(user2, "vaga100Akif1998@");
            user2.PasswordHash = hashedPass2;
            modelBuilder.Entity<User>().HasData(user2);

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "ADMIN" },
                new IdentityRole() { Id = "a4a9647b-cf6b-4dd0-bd1c-0ee3e946c57f", Name = "User", ConcurrencyStamp = "2", NormalizedName = "USER" }

                );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "b74ddd14-6340-4840-95c2-db12554843e5" },
                new IdentityUserRole<string>() { RoleId = "a4a9647b-cf6b-4dd0-bd1c-0ee3e946c57f", UserId = "29948c14-7554-434e-9772-5e6714faca71" }
                );
        }
    }
}
