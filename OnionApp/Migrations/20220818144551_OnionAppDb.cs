using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnionApp.Migrations
{
    public partial class OnionAppDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReadStatus = table.Column<bool>(type: "bit", nullable: false),
                    DeleteStatus = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SenderID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReciverID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_ReciverID",
                        column: x => x.ReciverID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_SenderID",
                        column: x => x.SenderID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("eaaa847c-d459-43f3-be8a-2c017325a980"), "850dd208-2d91-477f-8b8a-9eb1adb6b9df", "User", "USER" },
                    { new Guid("cde51b02-01d1-4b64-b208-b1cc16cc160d"), "cae55586-6822-4351-8613-66b3bb4cf76f", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("feb62675-d39b-4978-a617-6f5ecd995f40"), 0, "9b9b5a3b-9698-41b1-bbce-d8a2f4e6bb6e", "pasha@gmail.com", false, "Pasha", true, "Radeon", false, null, null, "PASHA", "AQAAAAEAACcQAAAAEM/EpFmp3qjjpaAbc1x962s83azlmNang6bKnr4KKJZuONJYTKF2OyRIT8Qvy0yJAQ==", "12321234", false, "", false, "pasha" },
                    { new Guid("4c26e97b-7a06-4e70-b5eb-23b3810e50c2"), 0, "3166b869-1459-4073-85d6-d003b74ca07e", "zena@gmail.com", false, "Zena", true, "Kulikova", false, null, null, "ZENA", "AQAAAAEAACcQAAAAENd/bSEcSIopXp8AioERZQX1WjiABeCUbcO9Ozt5tRwLt+zdfHI6DyS0UKpZl1iEjg==", "333333", false, "", false, "zena" },
                    { new Guid("6543c1d3-2277-4628-9c51-df6989985106"), 0, "13872ff1-d1ef-4faa-abc6-96fe6c4342d6", "nastya@gmail.com", false, "Nastya", true, "Kulikova", false, null, null, "NASTYA", "AQAAAAEAACcQAAAAEEZdi6BJrAhKfEXMnIbSjG/BKS5mcMXTCKAgl+n10LLvnV9iSFAUWwaLF40jDW2yvQ==", "123333", false, "", false, "nastya" },
                    { new Guid("e35e31ad-3a7d-4576-ae4a-19ff275d7840"), 0, "546c1b19-c94d-4c5e-97f4-7c899f0a864b", "mishkin@gmail.com", false, "Kovalev", true, "Mishkin", false, null, null, "KOLYA_MISHKIN", "AQAAAAEAACcQAAAAEPUAAkPV+jZUikiuLe8+X5P/qQlZHdnwReFJEbF9KNa8kyc0AsEk4qor2s6vPbHsfg==", "1231112", false, "", false, "kolya_mishkin" },
                    { new Guid("aac96843-4857-4fbe-9f8e-492a51030e8e"), 0, "20cf4074-422c-40a8-bac9-e807c48230ea", "kolya@gmail.com", false, "Kovalev", true, "Chipiqa", false, null, null, "KOLYA", "AQAAAAEAACcQAAAAECnqEAOnNFx9Bb81pSyV5b5YlKSYmrBixpHX2ec8xt+PM6+8AzXNvjGJZGhTADilmw==", "122223", false, "", false, "kolya" },
                    { new Guid("bcdf7c58-831f-405d-8b81-ae98726e4929"), 0, "51b5440f-ebe0-4b51-9c30-e9135c5a385f", "akif@gmail.com", false, "Akif", true, "Qurbanov", false, null, null, "AKIF", "AQAAAAEAACcQAAAAEE0ZShIC8GThGsoPgeez3UrmEXqWkjUuRVwDIGS0znDxhZ41AWvL84BUta/vyTmzXA==", "1232117", false, "", false, "akif" },
                    { new Guid("fa9ff1a5-87c7-46dd-9876-a22206fc804d"), 0, "b0782c9b-40d9-430e-9833-4f6c58dd15c6", "asif@gmail.com", false, "Asif", true, "Qurbanov", false, null, null, "ASIF", "AQAAAAEAACcQAAAAECtJiDjkDjBU9xhBsXNj4sqeR3Aga0h0vlYjb0ZqYLgBFahc+lsMs9WlnnsMAp5Q+Q==", "123321", false, "", false, "asif" },
                    { new Guid("04f56b24-dddf-4c8f-af96-814114406f96"), 0, "1396110d-c0ac-4b6a-aa1b-7e3d5f219c3e", "zeka@gmail.com", false, "Zeka", true, "Qasimli", false, null, null, "ZEKA", "AQAAAAEAACcQAAAAEIqVq1AY+CSPHHBVmvIJm/knkcc8OTQ7ZIphrmIYRIxZK5EqIgDZjwXFV8TCvVQfaA==", "123456", false, "", false, "zeka" },
                    { new Guid("4fe2aa35-3077-4c41-8e6c-91c73a1d3005"), 0, "b480386b-f905-405b-aab8-b3f8726096f9", "tural@gmail.com", false, "Tural", true, "Gehramanov", false, null, null, "TURAL", "AQAAAAEAACcQAAAAEAbkELL0rKUW/9GsjKny/1/r+to0BEECi7SgAYAvyvUvjypS5r1mRWAkTsf/I8JdYQ==", "12345", false, "", false, "tural" },
                    { new Guid("44d6b437-2798-4cc6-9cc2-42f4bdbd5ad9"), 0, "5957309e-9f55-4dd7-8da2-9f19aa30a089", "valeh@gmail.com", false, "Valeh", true, "Gehramanov", false, null, null, "VALEH", "AQAAAAEAACcQAAAAENyQX71iQ3RHKNcXr4iPtY2HzkTxvCUvtvxRX3XNb3zm1c5UBb1VEEwTjltxQapr6Q==", "1234", false, "", false, "valeh" },
                    { new Guid("a6104741-74ef-42b9-8b60-3e0fbc160870"), 0, "4cbddadb-752c-4669-b4e2-938b541d65d2", "vagif@gmail.com", false, "Vaqif", true, "Qurbanov", false, null, null, "VAGA", "AQAAAAEAACcQAAAAEGJvcmayCqdbva6g8T8rdkbpYOIQUKzr9lY9ZHeb1l6T4EE48gcOjzociM7gsQVChw==", "123", false, "", false, "vaga" },
                    { new Guid("1efeab64-374f-4360-b402-43972c7842bd"), 0, "1ec1be6b-26e4-489d-a9d7-ea21c6f97123", "vaga@gmail.com", false, "Kunjut", true, "Araxevich", false, null, null, "USER", "AQAAAAEAACcQAAAAEPGnjfgqcwkDiLzoIFboU7tECjqfkus+tKh2sALb8iBM5D8gOhwsb1IvTw5JcsomJg==", "1234567890", false, "", false, "user" },
                    { new Guid("288752a5-cb3f-4e10-a03b-08247674a7ae"), 0, "b10fde6b-dd67-465d-86b1-461acd1b272c", "admin@gmail.com", false, "Mishka", true, "Moya", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAECSE3oJfOsfCp8rFhpmwW4tDn/qQQ2PFi1l2GUaAucdyVDEDhXsIOaiFS1c43oB2Lg==", "1234567890", false, "", false, "Admin" },
                    { new Guid("8e7ffaa0-a720-44c3-9e67-aab3c4fd48a9"), 0, "2c635944-3726-45c6-b4ff-db8439d4ab0a", "pashkeyivich@gmail.com", false, "Pasha", true, "Radeon", false, null, null, "PASHKEYIVICH", "AQAAAAEAACcQAAAAEHC/7tPt1rC425J+RqMu9HNbbSX2vuzKoMsOLMdbDLDkiMxIG3aOXULqpJOqOG1Tjg==", "12311657", false, "", false, "pashkeyivich" },
                    { new Guid("c3d03140-4022-45e3-8350-6d60427153d3"), 0, "a082b5f5-da84-4514-98c1-2c1d1f01611f", "vagifGurbanov@gmail.com", false, "Vaqif", true, "Qurbanov", false, null, null, "VAQIF", "AQAAAAEAACcQAAAAEF3uqyz007g/KjFfiMaNGYRsZTRczh2UkXsm+68j5IBJrMfXHtl7Z9mRqEg4fDnWUw==", "123333999", false, "", false, "vaga100" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("cde51b02-01d1-4b64-b208-b1cc16cc160d"), new Guid("288752a5-cb3f-4e10-a03b-08247674a7ae") },
                    { new Guid("eaaa847c-d459-43f3-be8a-2c017325a980"), new Guid("1efeab64-374f-4360-b402-43972c7842bd") },
                    { new Guid("eaaa847c-d459-43f3-be8a-2c017325a980"), new Guid("a6104741-74ef-42b9-8b60-3e0fbc160870") },
                    { new Guid("eaaa847c-d459-43f3-be8a-2c017325a980"), new Guid("44d6b437-2798-4cc6-9cc2-42f4bdbd5ad9") },
                    { new Guid("eaaa847c-d459-43f3-be8a-2c017325a980"), new Guid("4fe2aa35-3077-4c41-8e6c-91c73a1d3005") },
                    { new Guid("eaaa847c-d459-43f3-be8a-2c017325a980"), new Guid("04f56b24-dddf-4c8f-af96-814114406f96") },
                    { new Guid("eaaa847c-d459-43f3-be8a-2c017325a980"), new Guid("fa9ff1a5-87c7-46dd-9876-a22206fc804d") },
                    { new Guid("eaaa847c-d459-43f3-be8a-2c017325a980"), new Guid("bcdf7c58-831f-405d-8b81-ae98726e4929") },
                    { new Guid("eaaa847c-d459-43f3-be8a-2c017325a980"), new Guid("aac96843-4857-4fbe-9f8e-492a51030e8e") },
                    { new Guid("eaaa847c-d459-43f3-be8a-2c017325a980"), new Guid("e35e31ad-3a7d-4576-ae4a-19ff275d7840") },
                    { new Guid("eaaa847c-d459-43f3-be8a-2c017325a980"), new Guid("6543c1d3-2277-4628-9c51-df6989985106") },
                    { new Guid("eaaa847c-d459-43f3-be8a-2c017325a980"), new Guid("4c26e97b-7a06-4e70-b5eb-23b3810e50c2") },
                    { new Guid("cde51b02-01d1-4b64-b208-b1cc16cc160d"), new Guid("feb62675-d39b-4978-a617-6f5ecd995f40") },
                    { new Guid("cde51b02-01d1-4b64-b208-b1cc16cc160d"), new Guid("8e7ffaa0-a720-44c3-9e67-aab3c4fd48a9") },
                    { new Guid("cde51b02-01d1-4b64-b208-b1cc16cc160d"), new Guid("c3d03140-4022-45e3-8350-6d60427153d3") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Images_UserId",
                table: "Images",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReciverID",
                table: "Messages",
                column: "ReciverID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderID",
                table: "Messages",
                column: "SenderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
