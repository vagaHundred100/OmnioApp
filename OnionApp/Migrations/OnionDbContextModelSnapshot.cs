﻿// <auto-generated />
using System;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace OnionApp.Migrations
{
    [DbContext(typeof(OnionDbContext))]
    partial class OnionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Domains.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Images");
                });

            modelBuilder.Entity("DAL.Domains.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeletedFromReciver")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeletedFromSender")
                        .HasColumnType("bit");

                    b.Property<bool>("ReadStatus")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ReciverID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SenderID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ReciverID");

                    b.HasIndex("SenderID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("DAL.Domains.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("eaaa847c-d459-43f3-be8a-2c017325a980"),
                            ConcurrencyStamp = "2af7d6df-a9f9-464f-a3cf-fc43c6353f9d",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = new Guid("cde51b02-01d1-4b64-b208-b1cc16cc160d"),
                            ConcurrencyStamp = "015a9aa8-13d0-4480-90c5-ac2b0f1d827c",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("DAL.Domains.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("288752a5-cb3f-4e10-a03b-08247674a7ae"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5c0fa9ec-03d8-430b-afef-a39f61971845",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Mishka",
                            IsEnabled = true,
                            LastName = "Moya",
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEA5hfUxxvP38ykN1xQnsKPXCcZq+p7LQMAqGNc53Xtfwovyv6YraU/ZUE1YmIEiS9A==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = new Guid("1efeab64-374f-4360-b402-43972c7842bd"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "377d914a-b722-4f52-a7e6-deac84041754",
                            Email = "vaga@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Kunjut",
                            IsEnabled = true,
                            LastName = "Araxevich",
                            LockoutEnabled = false,
                            NormalizedUserName = "USER",
                            PasswordHash = "AQAAAAEAACcQAAAAEAqQLAzP9PrIWnKxjbEeU2/wwpytGqJKFbO1z3LNxhzQh8TJOTiof7FqltoKA++1xg==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "user"
                        },
                        new
                        {
                            Id = new Guid("a6104741-74ef-42b9-8b60-3e0fbc160870"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "21e54d82-11a2-428c-a444-d1aba7bac254",
                            Email = "vagif@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Vaqif",
                            IsEnabled = true,
                            LastName = "Qurbanov",
                            LockoutEnabled = false,
                            NormalizedUserName = "VAGA",
                            PasswordHash = "AQAAAAEAACcQAAAAELF2ifH1xxNr4MvHhzhgsAAkS7W8PbqG4SRWwomyNzmmec1QZtCQ3JYSchvhBXWlNw==",
                            PhoneNumber = "123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "vaga"
                        },
                        new
                        {
                            Id = new Guid("44d6b437-2798-4cc6-9cc2-42f4bdbd5ad9"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "44c829f3-8efc-49af-bf82-dfd9d0545ed1",
                            Email = "valeh@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Valeh",
                            IsEnabled = true,
                            LastName = "Gehramanov",
                            LockoutEnabled = false,
                            NormalizedUserName = "VALEH",
                            PasswordHash = "AQAAAAEAACcQAAAAEEVNVn8uj0cEDegcjeBaBqYN9pcCNABQLfj7YlcQsamfufZ0J472kZK4qQL33ql4Jg==",
                            PhoneNumber = "1234",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "valeh"
                        },
                        new
                        {
                            Id = new Guid("4fe2aa35-3077-4c41-8e6c-91c73a1d3005"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "95171d16-12e7-4699-ae84-387c0aef612a",
                            Email = "tural@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Tural",
                            IsEnabled = true,
                            LastName = "Gehramanov",
                            LockoutEnabled = false,
                            NormalizedUserName = "TURAL",
                            PasswordHash = "AQAAAAEAACcQAAAAEM+V+9yctueyYxhsFKxTWyg5xNM9G21HZVBTIfxQxcrT7XlvwYu2wwFkKQxotAItpA==",
                            PhoneNumber = "12345",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "tural"
                        },
                        new
                        {
                            Id = new Guid("04f56b24-dddf-4c8f-af96-814114406f96"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e24de10d-9687-41b2-976d-9425ea847007",
                            Email = "zeka@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Zeka",
                            IsEnabled = true,
                            LastName = "Qasimli",
                            LockoutEnabled = false,
                            NormalizedUserName = "ZEKA",
                            PasswordHash = "AQAAAAEAACcQAAAAEBNtrc1yeH7KGf+6vpg45+eNNSPMfFZ1ZTMBxH8vx9uT6fpU6CNaVFhK1GqFy1doOA==",
                            PhoneNumber = "123456",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "zeka"
                        },
                        new
                        {
                            Id = new Guid("fa9ff1a5-87c7-46dd-9876-a22206fc804d"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "573ee4fc-cd2c-4017-94ae-8564172fd7a6",
                            Email = "asif@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Asif",
                            IsEnabled = true,
                            LastName = "Qurbanov",
                            LockoutEnabled = false,
                            NormalizedUserName = "ASIF",
                            PasswordHash = "AQAAAAEAACcQAAAAEKCcHsf5Vln5XrTTmpnAMRBrFTRBrww73wjlXNjpKRSmgWGwR7pc7x922p8VaE9V8g==",
                            PhoneNumber = "123321",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "asif"
                        },
                        new
                        {
                            Id = new Guid("bcdf7c58-831f-405d-8b81-ae98726e4929"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e59270f5-5586-48b2-a4b1-fd143c2c7a7e",
                            Email = "akif@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Akif",
                            IsEnabled = true,
                            LastName = "Qurbanov",
                            LockoutEnabled = false,
                            NormalizedUserName = "AKIF",
                            PasswordHash = "AQAAAAEAACcQAAAAEBXNJOSBUC2xP+aKS2ngWZmy1PPvcr49RUigKsbcXxQ8Gy4eRB5lszYOqwm8ehKSDQ==",
                            PhoneNumber = "1232117",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "akif"
                        },
                        new
                        {
                            Id = new Guid("aac96843-4857-4fbe-9f8e-492a51030e8e"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3972d326-ca31-4a31-8897-76b322a02fa6",
                            Email = "kolya@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Kovalev",
                            IsEnabled = true,
                            LastName = "Chipiqa",
                            LockoutEnabled = false,
                            NormalizedUserName = "KOLYA",
                            PasswordHash = "AQAAAAEAACcQAAAAEMGpCdLq+mUHPqZ3ikv3pVWp3ASSRHH+Uts1jR1twUxpfaxW6AKrNkhJXAwaADBKYA==",
                            PhoneNumber = "122223",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "kolya"
                        },
                        new
                        {
                            Id = new Guid("e35e31ad-3a7d-4576-ae4a-19ff275d7840"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8bb037d0-2fb0-453d-bf04-011044d6a5da",
                            Email = "mishkin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Kovalev",
                            IsEnabled = true,
                            LastName = "Mishkin",
                            LockoutEnabled = false,
                            NormalizedUserName = "KOLYA_MISHKIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEPCTAzB7mB8cqhLbGe4Yj1PXnEz+pHqnYjbvjeTMOBuakArBL5akWRAL7fC5a9zPjw==",
                            PhoneNumber = "1231112",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "kolya_mishkin"
                        },
                        new
                        {
                            Id = new Guid("6543c1d3-2277-4628-9c51-df6989985106"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2a389692-9fb7-48d5-bb15-b984c6fa411a",
                            Email = "nastya@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Nastya",
                            IsEnabled = true,
                            LastName = "Kulikova",
                            LockoutEnabled = false,
                            NormalizedUserName = "NASTYA",
                            PasswordHash = "AQAAAAEAACcQAAAAELSL4kW69pFjBbI5zN5AhdagnvaE1J+WFDjrK/kg3KgP/yudzxWmvIEcOF8U5dNAOw==",
                            PhoneNumber = "123333",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "nastya"
                        },
                        new
                        {
                            Id = new Guid("4c26e97b-7a06-4e70-b5eb-23b3810e50c2"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "20caaef7-5044-4328-9e59-e53bfe6d1290",
                            Email = "zena@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Zena",
                            IsEnabled = true,
                            LastName = "Kulikova",
                            LockoutEnabled = false,
                            NormalizedUserName = "ZENA",
                            PasswordHash = "AQAAAAEAACcQAAAAEKSlf778OzKY7CWIvwwq44mBn8uiXwgSw0Mx7AsPz3yJODpcXLB1JyN4hFmYM/+6zQ==",
                            PhoneNumber = "333333",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "zena"
                        },
                        new
                        {
                            Id = new Guid("feb62675-d39b-4978-a617-6f5ecd995f40"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "be6f79d7-7464-484d-a2a2-14b2cc278e6c",
                            Email = "pasha@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Pasha",
                            IsEnabled = true,
                            LastName = "Radeon",
                            LockoutEnabled = false,
                            NormalizedUserName = "PASHA",
                            PasswordHash = "AQAAAAEAACcQAAAAEINV4K9CapIkkNC53ZN6MJ4pt/mIszcp8hU+YjCSKEEjKHetpoma5ZTfsMp+fWvXdg==",
                            PhoneNumber = "12321234",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "pasha"
                        },
                        new
                        {
                            Id = new Guid("8e7ffaa0-a720-44c3-9e67-aab3c4fd48a9"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0e4185b4-3afd-4249-add2-69a526e9b6c7",
                            Email = "pashkeyivich@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Pasha",
                            IsEnabled = true,
                            LastName = "Radeon",
                            LockoutEnabled = false,
                            NormalizedUserName = "PASHKEYIVICH",
                            PasswordHash = "AQAAAAEAACcQAAAAEF56UqDv9q4PdIQ7V6xyb8qmWWlDBj1tHvgNjakoVgSPK7ylGjhLl41o9uMkVb9XDA==",
                            PhoneNumber = "12311657",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "pashkeyivich"
                        },
                        new
                        {
                            Id = new Guid("c3d03140-4022-45e3-8350-6d60427153d3"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d1ea4a15-f8e3-41ef-a53c-e27eb24d19b5",
                            Email = "vagifGurbanov@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Vaqif",
                            IsEnabled = true,
                            LastName = "Qurbanov",
                            LockoutEnabled = false,
                            NormalizedUserName = "VAQIF",
                            PasswordHash = "AQAAAAEAACcQAAAAENp+ypYcsAoTVjcS042gBQVF44YDpHrsd6Mok7VoLuvclgWmF4772qJTQYzt+HVhCw==",
                            PhoneNumber = "123333999",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "vaga100"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("1efeab64-374f-4360-b402-43972c7842bd"),
                            RoleId = new Guid("eaaa847c-d459-43f3-be8a-2c017325a980")
                        },
                        new
                        {
                            UserId = new Guid("a6104741-74ef-42b9-8b60-3e0fbc160870"),
                            RoleId = new Guid("eaaa847c-d459-43f3-be8a-2c017325a980")
                        },
                        new
                        {
                            UserId = new Guid("44d6b437-2798-4cc6-9cc2-42f4bdbd5ad9"),
                            RoleId = new Guid("eaaa847c-d459-43f3-be8a-2c017325a980")
                        },
                        new
                        {
                            UserId = new Guid("4fe2aa35-3077-4c41-8e6c-91c73a1d3005"),
                            RoleId = new Guid("eaaa847c-d459-43f3-be8a-2c017325a980")
                        },
                        new
                        {
                            UserId = new Guid("04f56b24-dddf-4c8f-af96-814114406f96"),
                            RoleId = new Guid("eaaa847c-d459-43f3-be8a-2c017325a980")
                        },
                        new
                        {
                            UserId = new Guid("fa9ff1a5-87c7-46dd-9876-a22206fc804d"),
                            RoleId = new Guid("eaaa847c-d459-43f3-be8a-2c017325a980")
                        },
                        new
                        {
                            UserId = new Guid("bcdf7c58-831f-405d-8b81-ae98726e4929"),
                            RoleId = new Guid("eaaa847c-d459-43f3-be8a-2c017325a980")
                        },
                        new
                        {
                            UserId = new Guid("aac96843-4857-4fbe-9f8e-492a51030e8e"),
                            RoleId = new Guid("eaaa847c-d459-43f3-be8a-2c017325a980")
                        },
                        new
                        {
                            UserId = new Guid("e35e31ad-3a7d-4576-ae4a-19ff275d7840"),
                            RoleId = new Guid("eaaa847c-d459-43f3-be8a-2c017325a980")
                        },
                        new
                        {
                            UserId = new Guid("6543c1d3-2277-4628-9c51-df6989985106"),
                            RoleId = new Guid("eaaa847c-d459-43f3-be8a-2c017325a980")
                        },
                        new
                        {
                            UserId = new Guid("4c26e97b-7a06-4e70-b5eb-23b3810e50c2"),
                            RoleId = new Guid("eaaa847c-d459-43f3-be8a-2c017325a980")
                        },
                        new
                        {
                            UserId = new Guid("feb62675-d39b-4978-a617-6f5ecd995f40"),
                            RoleId = new Guid("cde51b02-01d1-4b64-b208-b1cc16cc160d")
                        },
                        new
                        {
                            UserId = new Guid("8e7ffaa0-a720-44c3-9e67-aab3c4fd48a9"),
                            RoleId = new Guid("cde51b02-01d1-4b64-b208-b1cc16cc160d")
                        },
                        new
                        {
                            UserId = new Guid("c3d03140-4022-45e3-8350-6d60427153d3"),
                            RoleId = new Guid("cde51b02-01d1-4b64-b208-b1cc16cc160d")
                        },
                        new
                        {
                            UserId = new Guid("288752a5-cb3f-4e10-a03b-08247674a7ae"),
                            RoleId = new Guid("cde51b02-01d1-4b64-b208-b1cc16cc160d")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DAL.Domains.Image", b =>
                {
                    b.HasOne("DAL.Domains.User", "User")
                        .WithOne("Image")
                        .HasForeignKey("DAL.Domains.Image", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Domains.Message", b =>
                {
                    b.HasOne("DAL.Domains.User", "Reciver")
                        .WithMany("ReceivedMessages")
                        .HasForeignKey("ReciverID");

                    b.HasOne("DAL.Domains.User", "Sender")
                        .WithMany("SentMessages")
                        .HasForeignKey("SenderID");

                    b.Navigation("Reciver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("DAL.Domains.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("DAL.Domains.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("DAL.Domains.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("DAL.Domains.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Domains.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("DAL.Domains.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Domains.User", b =>
                {
                    b.Navigation("Image");

                    b.Navigation("ReceivedMessages");

                    b.Navigation("SentMessages");
                });
#pragma warning restore 612, 618
        }
    }
}