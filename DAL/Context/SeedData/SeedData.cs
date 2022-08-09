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

            User user1 = new User()
            {
                Id = Guid.NewGuid(),
                UserName = "Admin",
                Email = "admin@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890",
                FirstName = "Mishka",
                LastName = "Moya",
                NormalizedUserName = "ADMIN"
            };

            User user2 = new User()
            {
                Id = Guid.NewGuid(),
                UserName = "user",
                Email = "vaga@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890",
                FirstName = "Kunjut",
                LastName = "Araxevich",
                NormalizedUserName = "USER",

            };

            User user3 = new User()
            {
                Id = Guid.NewGuid(),
                UserName = "vaga",
                FirstName = "Vaqif",
                LastName = "Qurbanov",
                PhoneNumber = "123",
                Email = "vagif@gmail.com",
            };
            User user4 = new User()
            {
                Id = Guid.NewGuid(),
                UserName = "valeh",
                FirstName = "Valeh",
                LastName = "Gehramanov",
                PhoneNumber = "1234",
                Email = "valeh@gmail.com",
            };
            User user5 = new User()
            {
                Id = Guid.NewGuid(),
                UserName = "tural",
                FirstName = "Tural",
                LastName = "Gehramanov",
                PhoneNumber = "12345",
                Email = "tural@gmail.com"
            };
            User user6 = new User()
            {
                Id = Guid.NewGuid(),
                UserName = "zeka",
                FirstName = "Zeka",
                LastName = "Qasimli",
                PhoneNumber = "123456",
                Email = "zeka@gmail.com"
            };
            User user7 = new User()
            {
                Id = Guid.NewGuid(),
                UserName = "asif",
                FirstName = "Asif",
                LastName = "Qurbanov",
                PhoneNumber = "123321",
                Email = "asif@gmail.com"
            };
            User user8 = new User()
            {
                Id = Guid.NewGuid(),
                UserName = "akif",
                FirstName = "Akif",
                LastName = "Qurbanov",
                PhoneNumber = "1232117",
                Email = "akif@gmail.com"
            };
            User user9 = new User()
            {
                Id = Guid.NewGuid(),
                UserName = "kolya",
                FirstName = "Kovalev",
                LastName = "Chipiqa",
                PhoneNumber = "122223",
                Email = "kolya@gmail.com"
            };
            User user10 = new User()
            {
                Id = Guid.NewGuid(),
                UserName = "kolya_mishkin",
                FirstName = "Kovalev",
                LastName = "Mishkin",
                PhoneNumber = "1231112",
                Email = "mishkin@gmail.com"
            };
            User user11 = new User()
            {
                Id = Guid.NewGuid(),
                UserName = "nastya",
                FirstName = "Nastya",
                LastName = "Kulikova",
                PhoneNumber = "123333",
                Email = "nastya@gmail.com"
            };
            User user12 = new User()
            {
                Id = Guid.NewGuid(),
                UserName = "zena",
                FirstName = "Zena",
                LastName = "Kulikova",
                PhoneNumber = "333333",
                Email = "zena@gmail.com"
            };
            User user13 = new User()
            {
                Id = Guid.NewGuid(),
                UserName = "pasha",
                FirstName = "Pasha",
                LastName = "Radeon",
                PhoneNumber = "12321234",
                Email = "pasha@gmail.com"
            };
            User user14 = new User()
            {
                Id = Guid.NewGuid(),
                UserName = "pashkeyivich",
                FirstName = "Pasha",
                LastName = "Radeon",
                PhoneNumber = "12311657",
                Email = "pashkeyivich@gmail.com"
            };
            User user15 = new User()
            {
                Id = Guid.NewGuid(),
                UserName = "vaga100",
                FirstName = "Vaqif",
                LastName = "Qurbanov",
                PhoneNumber = "123333999",
                Email = "vagifGurbanov@gmail.com"
            };

            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            var hashedPass = passwordHasher.HashPassword(user1, "vaga100Akif1998@");
            user1.PasswordHash = hashedPass;
            user2.PasswordHash = hashedPass;
            user3.PasswordHash = hashedPass;
            user4.PasswordHash = hashedPass;
            user5.PasswordHash = hashedPass;
            user6.PasswordHash = hashedPass;
            user7.PasswordHash = hashedPass;
            user8.PasswordHash = hashedPass;
            user9.PasswordHash = hashedPass;
            user11.PasswordHash = hashedPass;
            user12.PasswordHash = hashedPass;
            user13.PasswordHash = hashedPass;
            user14.PasswordHash = hashedPass;
            user15.PasswordHash = hashedPass;

            modelBuilder.Entity<User>().HasData(user1);
            modelBuilder.Entity<User>().HasData(user2);
            modelBuilder.Entity<User>().HasData(user3);
            modelBuilder.Entity<User>().HasData(user4);
            modelBuilder.Entity<User>().HasData(user5);
            modelBuilder.Entity<User>().HasData(user6);
            modelBuilder.Entity<User>().HasData(user7);
            modelBuilder.Entity<User>().HasData(user8);
            modelBuilder.Entity<User>().HasData(user9);
            modelBuilder.Entity<User>().HasData(user10);
            modelBuilder.Entity<User>().HasData(user11);
            modelBuilder.Entity<User>().HasData(user12);
            modelBuilder.Entity<User>().HasData(user13);
            modelBuilder.Entity<User>().HasData(user14);
            modelBuilder.Entity<User>().HasData(user15);


            Role userRole = new Role {Id = Guid.NewGuid(), Name = "User", 
                                      NormalizedName = "USER" };
            Role adminRole = new Role{Id = Guid.NewGuid(),Name = "Admin", 
                                      NormalizedName = "ADMIN" };

            modelBuilder.Entity<Role>().HasData(userRole);
            modelBuilder.Entity<Role>().HasData(adminRole);

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>() { UserId = user2.Id, RoleId = userRole.Id },
                new IdentityUserRole<Guid>() { UserId = user3.Id, RoleId = userRole.Id },
                new IdentityUserRole<Guid>() { UserId = user4.Id, RoleId = userRole.Id },
                new IdentityUserRole<Guid>() { UserId = user5.Id, RoleId = userRole.Id },
                new IdentityUserRole<Guid>() { UserId = user6.Id, RoleId = userRole.Id },
                new IdentityUserRole<Guid>() { UserId = user7.Id, RoleId = userRole.Id },
                new IdentityUserRole<Guid>() { UserId = user8.Id, RoleId = userRole.Id },
                new IdentityUserRole<Guid>() { UserId = user9.Id, RoleId = userRole.Id },
                new IdentityUserRole<Guid>() { UserId = user10.Id, RoleId = userRole.Id },
                new IdentityUserRole<Guid>() { UserId = user11.Id, RoleId = userRole.Id },
                new IdentityUserRole<Guid>() { UserId = user12.Id, RoleId = userRole.Id },
                new IdentityUserRole<Guid>() { UserId = user13.Id, RoleId = adminRole.Id },
                new IdentityUserRole<Guid>() { UserId = user14.Id, RoleId = adminRole.Id },
                new IdentityUserRole<Guid>() { UserId = user15.Id, RoleId = adminRole.Id },
                new IdentityUserRole<Guid>() { UserId = user1.Id, RoleId = adminRole.Id }
                );
        }
    }
}
