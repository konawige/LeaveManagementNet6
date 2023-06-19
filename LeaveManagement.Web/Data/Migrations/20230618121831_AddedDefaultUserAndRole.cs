using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUserAndRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac2e8c7-5ad6-43e5-baaf-a332c9322a8c", "3eeb67d2-8002-447a-85bd-b73c1551f572", "Administrator", "ADMINISTRATOR" },
                    { "dfd2e8c7-5ad4-43e5-deaf-a332c9322a8r", "d416c120-97b8-4a00-a365-3fb212c5421a", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c532e8c6-5fd6-43e5-baaf-a332c9322a9d", 0, "83624c0d-21cf-46e9-82a3-93d3106e704b", null, null, "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEMryvYXYj7Hh15rzmJrxV8ajUWzXPEGkehfkyz7L9yyMBZV1v7AMxSnHClS0PxQFyA==", null, false, "d097133d-0329-4f87-938d-137c15a56c84", null, false, null },
                    { "e4425472-79e5-4da5-832e-1e43ad0bcd97", 0, "b03af8d4-df5e-4d77-a8a3-beed596596f3", null, null, "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEGAmQruYjToOFHhokAioVRmEMylIAW8Vtw+GdG1Tp2KYHOjNDU/ECfRNYgNIEzcXrA==", null, false, "b682288c-f2a1-4cb6-9f0b-bcf609dafb06", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac2e8c7-5ad6-43e5-baaf-a332c9322a8c", "c532e8c6-5fd6-43e5-baaf-a332c9322a9d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dfd2e8c7-5ad4-43e5-deaf-a332c9322a8r", "e4425472-79e5-4da5-832e-1e43ad0bcd97" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac2e8c7-5ad6-43e5-baaf-a332c9322a8c", "c532e8c6-5fd6-43e5-baaf-a332c9322a9d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dfd2e8c7-5ad4-43e5-deaf-a332c9322a8r", "e4425472-79e5-4da5-832e-1e43ad0bcd97" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac2e8c7-5ad6-43e5-baaf-a332c9322a8c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfd2e8c7-5ad4-43e5-deaf-a332c9322a8r");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c532e8c6-5fd6-43e5-baaf-a332c9322a9d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4425472-79e5-4da5-832e-1e43ad0bcd97");
        }
    }
}
