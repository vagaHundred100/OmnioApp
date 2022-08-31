using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnionApp.Migrations
{
    public partial class chaingingMessageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeleteStatus",
                table: "Messages",
                newName: "IsDeletedFromSender");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeletedFromReciver",
                table: "Messages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cde51b02-01d1-4b64-b208-b1cc16cc160d"),
                column: "ConcurrencyStamp",
                value: "015a9aa8-13d0-4480-90c5-ac2b0f1d827c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eaaa847c-d459-43f3-be8a-2c017325a980"),
                column: "ConcurrencyStamp",
                value: "2af7d6df-a9f9-464f-a3cf-fc43c6353f9d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("04f56b24-dddf-4c8f-af96-814114406f96"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e24de10d-9687-41b2-976d-9425ea847007", "AQAAAAEAACcQAAAAEBNtrc1yeH7KGf+6vpg45+eNNSPMfFZ1ZTMBxH8vx9uT6fpU6CNaVFhK1GqFy1doOA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1efeab64-374f-4360-b402-43972c7842bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "377d914a-b722-4f52-a7e6-deac84041754", "AQAAAAEAACcQAAAAEAqQLAzP9PrIWnKxjbEeU2/wwpytGqJKFbO1z3LNxhzQh8TJOTiof7FqltoKA++1xg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("288752a5-cb3f-4e10-a03b-08247674a7ae"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5c0fa9ec-03d8-430b-afef-a39f61971845", "AQAAAAEAACcQAAAAEA5hfUxxvP38ykN1xQnsKPXCcZq+p7LQMAqGNc53Xtfwovyv6YraU/ZUE1YmIEiS9A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("44d6b437-2798-4cc6-9cc2-42f4bdbd5ad9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "44c829f3-8efc-49af-bf82-dfd9d0545ed1", "AQAAAAEAACcQAAAAEEVNVn8uj0cEDegcjeBaBqYN9pcCNABQLfj7YlcQsamfufZ0J472kZK4qQL33ql4Jg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4c26e97b-7a06-4e70-b5eb-23b3810e50c2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "20caaef7-5044-4328-9e59-e53bfe6d1290", "AQAAAAEAACcQAAAAEKSlf778OzKY7CWIvwwq44mBn8uiXwgSw0Mx7AsPz3yJODpcXLB1JyN4hFmYM/+6zQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4fe2aa35-3077-4c41-8e6c-91c73a1d3005"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "95171d16-12e7-4699-ae84-387c0aef612a", "AQAAAAEAACcQAAAAEM+V+9yctueyYxhsFKxTWyg5xNM9G21HZVBTIfxQxcrT7XlvwYu2wwFkKQxotAItpA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6543c1d3-2277-4628-9c51-df6989985106"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a389692-9fb7-48d5-bb15-b984c6fa411a", "AQAAAAEAACcQAAAAELSL4kW69pFjBbI5zN5AhdagnvaE1J+WFDjrK/kg3KgP/yudzxWmvIEcOF8U5dNAOw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8e7ffaa0-a720-44c3-9e67-aab3c4fd48a9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0e4185b4-3afd-4249-add2-69a526e9b6c7", "AQAAAAEAACcQAAAAEF56UqDv9q4PdIQ7V6xyb8qmWWlDBj1tHvgNjakoVgSPK7ylGjhLl41o9uMkVb9XDA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a6104741-74ef-42b9-8b60-3e0fbc160870"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21e54d82-11a2-428c-a444-d1aba7bac254", "AQAAAAEAACcQAAAAELF2ifH1xxNr4MvHhzhgsAAkS7W8PbqG4SRWwomyNzmmec1QZtCQ3JYSchvhBXWlNw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aac96843-4857-4fbe-9f8e-492a51030e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3972d326-ca31-4a31-8897-76b322a02fa6", "AQAAAAEAACcQAAAAEMGpCdLq+mUHPqZ3ikv3pVWp3ASSRHH+Uts1jR1twUxpfaxW6AKrNkhJXAwaADBKYA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bcdf7c58-831f-405d-8b81-ae98726e4929"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e59270f5-5586-48b2-a4b1-fd143c2c7a7e", "AQAAAAEAACcQAAAAEBXNJOSBUC2xP+aKS2ngWZmy1PPvcr49RUigKsbcXxQ8Gy4eRB5lszYOqwm8ehKSDQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c3d03140-4022-45e3-8350-6d60427153d3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d1ea4a15-f8e3-41ef-a53c-e27eb24d19b5", "AQAAAAEAACcQAAAAENp+ypYcsAoTVjcS042gBQVF44YDpHrsd6Mok7VoLuvclgWmF4772qJTQYzt+HVhCw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e35e31ad-3a7d-4576-ae4a-19ff275d7840"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8bb037d0-2fb0-453d-bf04-011044d6a5da", "AQAAAAEAACcQAAAAEPCTAzB7mB8cqhLbGe4Yj1PXnEz+pHqnYjbvjeTMOBuakArBL5akWRAL7fC5a9zPjw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fa9ff1a5-87c7-46dd-9876-a22206fc804d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "573ee4fc-cd2c-4017-94ae-8564172fd7a6", "AQAAAAEAACcQAAAAEKCcHsf5Vln5XrTTmpnAMRBrFTRBrww73wjlXNjpKRSmgWGwR7pc7x922p8VaE9V8g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("feb62675-d39b-4978-a617-6f5ecd995f40"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "be6f79d7-7464-484d-a2a2-14b2cc278e6c", "AQAAAAEAACcQAAAAEINV4K9CapIkkNC53ZN6MJ4pt/mIszcp8hU+YjCSKEEjKHetpoma5ZTfsMp+fWvXdg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeletedFromReciver",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "IsDeletedFromSender",
                table: "Messages",
                newName: "DeleteStatus");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cde51b02-01d1-4b64-b208-b1cc16cc160d"),
                column: "ConcurrencyStamp",
                value: "cae55586-6822-4351-8613-66b3bb4cf76f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eaaa847c-d459-43f3-be8a-2c017325a980"),
                column: "ConcurrencyStamp",
                value: "850dd208-2d91-477f-8b8a-9eb1adb6b9df");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("04f56b24-dddf-4c8f-af96-814114406f96"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1396110d-c0ac-4b6a-aa1b-7e3d5f219c3e", "AQAAAAEAACcQAAAAEIqVq1AY+CSPHHBVmvIJm/knkcc8OTQ7ZIphrmIYRIxZK5EqIgDZjwXFV8TCvVQfaA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1efeab64-374f-4360-b402-43972c7842bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ec1be6b-26e4-489d-a9d7-ea21c6f97123", "AQAAAAEAACcQAAAAEPGnjfgqcwkDiLzoIFboU7tECjqfkus+tKh2sALb8iBM5D8gOhwsb1IvTw5JcsomJg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("288752a5-cb3f-4e10-a03b-08247674a7ae"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b10fde6b-dd67-465d-86b1-461acd1b272c", "AQAAAAEAACcQAAAAECSE3oJfOsfCp8rFhpmwW4tDn/qQQ2PFi1l2GUaAucdyVDEDhXsIOaiFS1c43oB2Lg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("44d6b437-2798-4cc6-9cc2-42f4bdbd5ad9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5957309e-9f55-4dd7-8da2-9f19aa30a089", "AQAAAAEAACcQAAAAENyQX71iQ3RHKNcXr4iPtY2HzkTxvCUvtvxRX3XNb3zm1c5UBb1VEEwTjltxQapr6Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4c26e97b-7a06-4e70-b5eb-23b3810e50c2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3166b869-1459-4073-85d6-d003b74ca07e", "AQAAAAEAACcQAAAAENd/bSEcSIopXp8AioERZQX1WjiABeCUbcO9Ozt5tRwLt+zdfHI6DyS0UKpZl1iEjg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4fe2aa35-3077-4c41-8e6c-91c73a1d3005"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b480386b-f905-405b-aab8-b3f8726096f9", "AQAAAAEAACcQAAAAEAbkELL0rKUW/9GsjKny/1/r+to0BEECi7SgAYAvyvUvjypS5r1mRWAkTsf/I8JdYQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6543c1d3-2277-4628-9c51-df6989985106"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "13872ff1-d1ef-4faa-abc6-96fe6c4342d6", "AQAAAAEAACcQAAAAEEZdi6BJrAhKfEXMnIbSjG/BKS5mcMXTCKAgl+n10LLvnV9iSFAUWwaLF40jDW2yvQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8e7ffaa0-a720-44c3-9e67-aab3c4fd48a9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2c635944-3726-45c6-b4ff-db8439d4ab0a", "AQAAAAEAACcQAAAAEHC/7tPt1rC425J+RqMu9HNbbSX2vuzKoMsOLMdbDLDkiMxIG3aOXULqpJOqOG1Tjg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a6104741-74ef-42b9-8b60-3e0fbc160870"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4cbddadb-752c-4669-b4e2-938b541d65d2", "AQAAAAEAACcQAAAAEGJvcmayCqdbva6g8T8rdkbpYOIQUKzr9lY9ZHeb1l6T4EE48gcOjzociM7gsQVChw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aac96843-4857-4fbe-9f8e-492a51030e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "20cf4074-422c-40a8-bac9-e807c48230ea", "AQAAAAEAACcQAAAAECnqEAOnNFx9Bb81pSyV5b5YlKSYmrBixpHX2ec8xt+PM6+8AzXNvjGJZGhTADilmw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bcdf7c58-831f-405d-8b81-ae98726e4929"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "51b5440f-ebe0-4b51-9c30-e9135c5a385f", "AQAAAAEAACcQAAAAEE0ZShIC8GThGsoPgeez3UrmEXqWkjUuRVwDIGS0znDxhZ41AWvL84BUta/vyTmzXA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c3d03140-4022-45e3-8350-6d60427153d3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a082b5f5-da84-4514-98c1-2c1d1f01611f", "AQAAAAEAACcQAAAAEF3uqyz007g/KjFfiMaNGYRsZTRczh2UkXsm+68j5IBJrMfXHtl7Z9mRqEg4fDnWUw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e35e31ad-3a7d-4576-ae4a-19ff275d7840"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "546c1b19-c94d-4c5e-97f4-7c899f0a864b", "AQAAAAEAACcQAAAAEPUAAkPV+jZUikiuLe8+X5P/qQlZHdnwReFJEbF9KNa8kyc0AsEk4qor2s6vPbHsfg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fa9ff1a5-87c7-46dd-9876-a22206fc804d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b0782c9b-40d9-430e-9833-4f6c58dd15c6", "AQAAAAEAACcQAAAAECtJiDjkDjBU9xhBsXNj4sqeR3Aga0h0vlYjb0ZqYLgBFahc+lsMs9WlnnsMAp5Q+Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("feb62675-d39b-4978-a617-6f5ecd995f40"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9b9b5a3b-9698-41b1-bbce-d8a2f4e6bb6e", "AQAAAAEAACcQAAAAEM/EpFmp3qjjpaAbc1x962s83azlmNang6bKnr4KKJZuONJYTKF2OyRIT8Qvy0yJAQ==" });
        }
    }
}
