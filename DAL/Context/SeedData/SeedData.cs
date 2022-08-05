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
                FirstName = "Mishka",
                LastName = "Moya",
                NormalizedUserName = "ADMIN"
            };

            User user2 = new User()
            {
                Id = "29948c14-7554-434e-9772-5e6714faca71",
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
                Id = "8a47693f-3df7-4bd6-86cd-b95a7575993e",
                UserName = "vaga",
                FirstName = "Vaqif",
                LastName = "Qurbanov",
                PhoneNumber = "123",
                Email = "vagif@gmail.com",
            };
            User user4 = new User()
            {
                Id = "f7402d95-c359-47a8-924b-de875403302b",
                UserName = "valeh",
                FirstName = "Valeh",
                LastName = "Gehramanov",
                PhoneNumber = "1234",
                Email = "valeh@gmail.com",
            };
            User user5 = new User()
            {
                Id = "734d5b7d-f547-480b-acdb-b966b5dbf0fb",
                UserName = "tural",
                FirstName = "Tural",
                LastName = "Gehramanov",
                PhoneNumber = "12345",
                Email = "tural@gmail.com"
            };
            User user6 = new User()
            {
                Id = "48b66625-946c-47c0-a6f5-4c8b54423f60",
                UserName = "zeka",
                FirstName = "Zeka",
                LastName = "Qasimli",
                PhoneNumber = "123456",
                Email = "zeka@gmail.com"
            };
            User user7 = new User()
            {
                Id = "89d9f27a-0dfc-4015-bdbc-10822ca33548",
                UserName = "asif",
                FirstName = "Asif",
                LastName = "Qurbanov",
                PhoneNumber = "123321",
                Email = "asif@gmail.com"
            };
            User user8 = new User()
            {
                Id = "aca90c9d-53fc-4f48-999c-ef5df6c861bb",
                UserName = "akif",
                FirstName = "Akif",
                LastName = "Qurbanov",
                PhoneNumber = "1232117",
                Email = "akif@gmail.com"
            };
            User user9 = new User()
            {
                Id = "fd1b723a-2585-40f1-aa53-b29dadd196cb",
                UserName = "kolya",
                FirstName = "Kovalev",
                LastName = "Chipiqa",
                PhoneNumber = "122223",
                Email = "kolya@gmail.com"
            };
            User user10 = new User()
            {
                Id = "dabc7eeb-3e7a-478b-bd2c-bef6d7eb9ed4",
                UserName = "kolya_mishkin",
                FirstName = "Kovalev",
                LastName = "Mishkin",
                PhoneNumber = "1231112",
                Email = "mishkin@gmail.com"
            };
            User user11 = new User()
            {
                Id = "25626188-42af-4ff2-b000-449282e009ce",
                UserName = "nastya",
                FirstName = "Nastya",
                LastName = "Kulikova",
                PhoneNumber = "123333",
                Email = "nastya@gmail.com"
            };
            User user12 = new User()
            {
                Id = "71d10d38-4f54-4351-bfa0-a0f482079da4",
                UserName = "zena",
                FirstName = "Zena",
                LastName = "Kulikova",
                PhoneNumber = "333333",
                Email = "zena@gmail.com"
            };
            User user13 = new User()
            {
                Id = "5da69b83-cf12-4ef4-9adc-b38eceff1bbc",
                UserName = "pasha",
                FirstName = "Pasha",
                LastName = "Radeon",
                PhoneNumber = "12321234",
                Email = "pasha@gmail.com"
            };
            User user14 = new User()
            {
                Id = "9b66ad9f-46c9-4a6f-b17a-b6a8c47a1e54",
                UserName = "pashkeyivich",
                FirstName = "Pasha",
                LastName = "Radeon",
                PhoneNumber = "12311657",
                Email = "pashkeyivich@gmail.com"
            };
            User user15 = new User()
            {
                Id = "89b3cdc0-b37e-4212-bdcf-f3e4bcda979a",
                UserName = "vaga100",
                FirstName = "Vaqif",
                LastName = "Qurbanov",
                PhoneNumber = "123333999",
                Email = "vagifGurbanov@gmail.com"
            };

            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            var hashedPass = passwordHasher.HashPassword(user, "vaga100Akif1998@");
            user.PasswordHash = hashedPass;
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

            modelBuilder.Entity<User>().HasData(user);
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


            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "ADMIN" },
                new IdentityRole() { Id = "a4a9647b-cf6b-4dd0-bd1c-0ee3e946c57f", Name = "User", ConcurrencyStamp = "2", NormalizedName = "USER" }

                );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "a4a9647b-cf6b-4dd0-bd1c-0ee3e946c57f", UserId = "29948c14-7554-434e-9772-5e6714faca71" },
                new IdentityUserRole<string>() { RoleId = "a4a9647b-cf6b-4dd0-bd1c-0ee3e946c57f", UserId = "89b3cdc0-b37e-4212-bdcf-f3e4bcda979a" },
                new IdentityUserRole<string>() { RoleId = "a4a9647b-cf6b-4dd0-bd1c-0ee3e946c57f", UserId = "9b66ad9f-46c9-4a6f-b17a-b6a8c47a1e54" },
                new IdentityUserRole<string>() { RoleId = "a4a9647b-cf6b-4dd0-bd1c-0ee3e946c57f", UserId = "5da69b83-cf12-4ef4-9adc-b38eceff1bbc" },
                new IdentityUserRole<string>() { RoleId = "a4a9647b-cf6b-4dd0-bd1c-0ee3e946c57f", UserId = "71d10d38-4f54-4351-bfa0-a0f482079da4" },
                new IdentityUserRole<string>() { RoleId = "a4a9647b-cf6b-4dd0-bd1c-0ee3e946c57f", UserId = "25626188-42af-4ff2-b000-449282e009ce" },
                new IdentityUserRole<string>() { RoleId = "a4a9647b-cf6b-4dd0-bd1c-0ee3e946c57f", UserId = "dabc7eeb-3e7a-478b-bd2c-bef6d7eb9ed4" },
                new IdentityUserRole<string>() { RoleId = "a4a9647b-cf6b-4dd0-bd1c-0ee3e946c57f", UserId = "fd1b723a-2585-40f1-aa53-b29dadd196cb" },
                new IdentityUserRole<string>() { RoleId = "a4a9647b-cf6b-4dd0-bd1c-0ee3e946c57f", UserId = "aca90c9d-53fc-4f48-999c-ef5df6c861bb" },
                new IdentityUserRole<string>() { RoleId = "a4a9647b-cf6b-4dd0-bd1c-0ee3e946c57f", UserId = "89d9f27a-0dfc-4015-bdbc-10822ca33548" },
                new IdentityUserRole<string>() { RoleId = "a4a9647b-cf6b-4dd0-bd1c-0ee3e946c57f", UserId = "48b66625-946c-47c0-a6f5-4c8b54423f60" },
                new IdentityUserRole<string>() { RoleId = "a4a9647b-cf6b-4dd0-bd1c-0ee3e946c57f", UserId = "734d5b7d-f547-480b-acdb-b966b5dbf0fb" },
                new IdentityUserRole<string>() { RoleId = "a4a9647b-cf6b-4dd0-bd1c-0ee3e946c57f", UserId = "f7402d95-c359-47a8-924b-de875403302b" },
                new IdentityUserRole<string>() { RoleId = "a4a9647b-cf6b-4dd0-bd1c-0ee3e946c57f", UserId = "8a47693f-3df7-4bd6-86cd-b95a7575993e" },
                new IdentityUserRole<string>() { RoleId = "a4a9647b-cf6b-4dd0-bd1c-0ee3e946c57f", UserId = "b74ddd14-6340-4840-95c2-db12554843e5" },
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "dabc7eeb-3e7a-478b-bd2c-bef6d7eb9ed4" },
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "b74ddd14-6340-4840-95c2-db12554843e5" },
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "89d9f27a-0dfc-4015-bdbc-10822ca33548" },
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "25626188-42af-4ff2-b000-449282e009ce" }
                );
        }
    }
}
