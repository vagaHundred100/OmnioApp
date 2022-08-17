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
    public static class SeedUsersAndRoles
    {
        private static List<Guid> userGuids = new List<Guid>()
        {
            new Guid("288752a5-cb3f-4e10-a03b-08247674a7ae"),
            new Guid("1efeab64-374f-4360-b402-43972c7842bd"),
            new Guid("a6104741-74ef-42b9-8b60-3e0fbc160870"),
            new Guid("44d6b437-2798-4cc6-9cc2-42f4bdbd5ad9"),
            new Guid("4fe2aa35-3077-4c41-8e6c-91c73a1d3005"),
            new Guid("04f56b24-dddf-4c8f-af96-814114406f96"),
            new Guid("fa9ff1a5-87c7-46dd-9876-a22206fc804d"),
            new Guid("bcdf7c58-831f-405d-8b81-ae98726e4929"),
            new Guid("aac96843-4857-4fbe-9f8e-492a51030e8e"),
            new Guid("e35e31ad-3a7d-4576-ae4a-19ff275d7840"),
            new Guid("6543c1d3-2277-4628-9c51-df6989985106"),
            new Guid("4c26e97b-7a06-4e70-b5eb-23b3810e50c2"),
            new Guid("feb62675-d39b-4978-a617-6f5ecd995f40"),
            new Guid("8e7ffaa0-a720-44c3-9e67-aab3c4fd48a9"),
            new Guid("c3d03140-4022-45e3-8350-6d60427153d3")
        };

        private static List<Guid> roleGuids = new List<Guid>()
        {
            new Guid("eaaa847c-d459-43f3-be8a-2c017325a980"),
            new Guid("cde51b02-01d1-4b64-b208-b1cc16cc160d")
        };

        private static List<Role> roles = new List<Role>()
        {
             new Role
             {
                Id = roleGuids[0],
                Name = "User",
                NormalizedName = "USER"
             },
             new  Role
             {
                Id = roleGuids[1],
                Name = "Admin",
                NormalizedName = "ADMIN"
             }
        };

        private static List<User> users = new List<User>()
        {
             new User()
            {
                Id = userGuids[0],
                UserName = "Admin",
                Email = "admin@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890",
                FirstName = "Mishka",
                LastName = "Moya",
                NormalizedUserName = "ADMIN",
                PasswordHash = new PasswordHasher<User>().HashPassword(null,"vaga100Akif1998@"),
                SecurityStamp = string.Empty
            },
             new User()
            {
                Id = userGuids[1],
                UserName = "user",
                Email = "vaga@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890",
                FirstName = "Kunjut",
                LastName = "Araxevich",
                SecurityStamp = string.Empty,
                PasswordHash = new PasswordHasher<User>().HashPassword(null,"vaga100Akif1998@"),
                NormalizedUserName = "USER"

            },
             new User()
            {
                Id = userGuids[2],
                UserName = "vaga",
                FirstName = "Vaqif",
                LastName = "Qurbanov",
                PhoneNumber = "123",
                Email = "vagif@gmail.com",
                SecurityStamp = string.Empty,
                PasswordHash = new PasswordHasher<User>().HashPassword(null,"vaga100Akif1998@"),
                NormalizedUserName = "VAGA"
            },
             new User()
            {
                Id = userGuids[3],
                UserName = "valeh",
                FirstName = "Valeh",
                LastName = "Gehramanov",
                PhoneNumber = "1234",
                Email = "valeh@gmail.com",
                SecurityStamp = string.Empty,
                PasswordHash = new PasswordHasher<User>().HashPassword(null,"vaga100Akif1998@"),
                NormalizedUserName = "VALEH"
            },
             new User()
            {
                Id = userGuids[4],
                UserName = "tural",
                FirstName = "Tural",
                LastName = "Gehramanov",
                PhoneNumber = "12345",
                Email = "tural@gmail.com",
                SecurityStamp = string.Empty,
                PasswordHash = new PasswordHasher<User>().HashPassword(null,"vaga100Akif1998@"),
                NormalizedUserName = "TURAL"
            },
             new User()
            {
                Id = userGuids[5],
                UserName = "zeka",
                FirstName = "Zeka",
                LastName = "Qasimli",
                PhoneNumber = "123456",
                Email = "zeka@gmail.com",
                SecurityStamp = string.Empty,
                PasswordHash = new PasswordHasher<User>().HashPassword(null,"vaga100Akif1998@"),
                NormalizedUserName = "ZEKA"
            },
             new User()
            {
                Id = userGuids[6],
                UserName = "asif",
                FirstName = "Asif",
                LastName = "Qurbanov",
                PhoneNumber = "123321",
                Email = "asif@gmail.com",
                SecurityStamp = string.Empty,
                PasswordHash = new PasswordHasher<User>().HashPassword(null,"vaga100Akif1998@"),
                NormalizedUserName = "ASIF"
            },
             new User()
            {
                Id = userGuids[7],
                UserName = "akif",
                FirstName = "Akif",
                LastName = "Qurbanov",
                PhoneNumber = "1232117",
                Email = "akif@gmail.com",
                SecurityStamp = string.Empty,
                PasswordHash = new PasswordHasher<User>().HashPassword(null,"vaga100Akif1998@"),
                NormalizedUserName = "AKIF"
            },
             new User()
            {
                Id = userGuids[8],
                UserName = "kolya",
                FirstName = "Kovalev",
                LastName = "Chipiqa",
                PhoneNumber = "122223",
                Email = "kolya@gmail.com",
                SecurityStamp = string.Empty,
                PasswordHash = new PasswordHasher<User>().HashPassword(null,"vaga100Akif1998@"),
                NormalizedUserName = "KOLYA"
            },
             new User()
            {
                Id = userGuids[9],
                UserName = "kolya_mishkin",
                FirstName = "Kovalev",
                LastName = "Mishkin",
                PhoneNumber = "1231112",
                Email = "mishkin@gmail.com",
                SecurityStamp = string.Empty,
                PasswordHash = new PasswordHasher<User>().HashPassword(null,"vaga100Akif1998@"),
                NormalizedUserName = "KOLYA_MISHKIN"
             },
             new User()
            {
                Id = userGuids[10],
                UserName = "nastya",
                FirstName = "Nastya",
                LastName = "Kulikova",
                PhoneNumber = "123333",
                Email = "nastya@gmail.com",
                SecurityStamp = string.Empty,
                PasswordHash = new PasswordHasher<User>().HashPassword(null,"vaga100Akif1998@"),
                NormalizedUserName = "NASTYA"
             },
             new User()
            {
                Id = userGuids[11],
                UserName = "zena",
                FirstName = "Zena",
                LastName = "Kulikova",
                PhoneNumber = "333333",
                Email = "zena@gmail.com",
                SecurityStamp = string.Empty,
                PasswordHash = new PasswordHasher<User>().HashPassword(null,"vaga100Akif1998@"),
                NormalizedUserName = "ZENA"
             },
             new User()
            {
                Id = userGuids[12],
                UserName = "pasha",
                FirstName = "Pasha",
                LastName = "Radeon",
                PhoneNumber = "12321234",
                Email = "pasha@gmail.com",
                SecurityStamp = string.Empty,
                PasswordHash = new PasswordHasher<User>().HashPassword(null,"vaga100Akif1998@"),
                NormalizedUserName = "PASHA"
             },
             new User()
            {
                Id = userGuids[13],
                UserName = "pashkeyivich",
                FirstName = "Pasha",
                LastName = "Radeon",
                PhoneNumber = "12311657",
                Email = "pashkeyivich@gmail.com",
                SecurityStamp = string.Empty,
                PasswordHash = new PasswordHasher<User>().HashPassword(null,"vaga100Akif1998@"),
                NormalizedUserName = "PASHKEYIVICH"
             },
             new User()
            {
                Id = userGuids[14],
                UserName = "vaga100",
                FirstName = "Vaqif",
                LastName = "Qurbanov",
                PhoneNumber = "123333999",
                Email = "vagifGurbanov@gmail.com",
                SecurityStamp = string.Empty,
                PasswordHash = new PasswordHasher<User>().HashPassword(null,"vaga100Akif1998@"),
                NormalizedUserName = "VAQIF"
             }
        };
        private static List<IdentityUserRole<Guid>> userRoles = new List<IdentityUserRole<Guid>>()
        {
                new IdentityUserRole<Guid>() { UserId = userGuids[1], RoleId = roleGuids[0] },
                new IdentityUserRole<Guid>() { UserId = userGuids[2], RoleId = roleGuids[0] },
                new IdentityUserRole<Guid>() { UserId = userGuids[3], RoleId = roleGuids[0] },
                new IdentityUserRole<Guid>() { UserId = userGuids[4], RoleId = roleGuids[0] },
                new IdentityUserRole<Guid>() { UserId = userGuids[5], RoleId = roleGuids[0] },
                new IdentityUserRole<Guid>() { UserId = userGuids[6], RoleId = roleGuids[0] },
                new IdentityUserRole<Guid>() { UserId = userGuids[7], RoleId = roleGuids[0] },
                new IdentityUserRole<Guid>() { UserId = userGuids[8], RoleId = roleGuids[0] },
                new IdentityUserRole<Guid>() { UserId = userGuids[9], RoleId = roleGuids[0] },
                new IdentityUserRole<Guid>() { UserId = userGuids[10], RoleId = roleGuids[0] },
                new IdentityUserRole<Guid>() { UserId = userGuids[11], RoleId = roleGuids[0] },
                new IdentityUserRole<Guid>() { UserId = userGuids[12], RoleId = roleGuids[1] },
                new IdentityUserRole<Guid>() { UserId = userGuids[13], RoleId = roleGuids[1] },
                new IdentityUserRole<Guid>() { UserId = userGuids[14], RoleId = roleGuids[1] },
                new IdentityUserRole<Guid>() { UserId = userGuids[0], RoleId = roleGuids[1] }
        };
        public static void IncertUsersAndRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Role>().HasData(roles);
            modelBuilder.Entity<IdentityRole<Guid>>().HasData(userRoles);
        }
    }
}
