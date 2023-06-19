using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac2e8c7-5ad6-43e5-baaf-a332c9322a8c",
                column: "ConcurrencyStamp",
                value: "f00fde36-a55c-4a12-9ad9-ff749265af26");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfd2e8c7-5ad4-43e5-deaf-a332c9322a8r",
                column: "ConcurrencyStamp",
                value: "26249b4a-adb4-4640-9de5-b621ca1d782b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c532e8c6-5fd6-43e5-baaf-a332c9322a9d",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8b463bb5-ff14-4f25-aee7-4be76a15a307", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEOTCj+/cFT/aFkxtjy63aDDZN2Vxq9rpsYREqnWQW4XZhxtxeeXakQ+FL44xkhMoBQ==", "b4adb9d3-698a-43c2-8e1a-6103e8fea903", "ADMIN@LOCALHOST.COM" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4425472-79e5-4da5-832e-1e43ad0bcd97",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "132936ac-8196-487e-8879-bf2814124f97", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFBLwKrYVEXxKYS9E6WkS0mMuh3kcaKuc5ZOqNz0xDbkt5p9Q9Gm/CCn+Zn+uGpHsw==", "dbf2f8a5-99c4-4386-b86a-96b8feedc535", "USER@LOCALHOST.COM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac2e8c7-5ad6-43e5-baaf-a332c9322a8c",
                column: "ConcurrencyStamp",
                value: "3eeb67d2-8002-447a-85bd-b73c1551f572");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfd2e8c7-5ad4-43e5-deaf-a332c9322a8r",
                column: "ConcurrencyStamp",
                value: "d416c120-97b8-4a00-a365-3fb212c5421a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c532e8c6-5fd6-43e5-baaf-a332c9322a9d",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "83624c0d-21cf-46e9-82a3-93d3106e704b", false, null, "AQAAAAEAACcQAAAAEMryvYXYj7Hh15rzmJrxV8ajUWzXPEGkehfkyz7L9yyMBZV1v7AMxSnHClS0PxQFyA==", "d097133d-0329-4f87-938d-137c15a56c84", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4425472-79e5-4da5-832e-1e43ad0bcd97",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b03af8d4-df5e-4d77-a8a3-beed596596f3", false, null, "AQAAAAEAACcQAAAAEGAmQruYjToOFHhokAioVRmEMylIAW8Vtw+GdG1Tp2KYHOjNDU/ECfRNYgNIEzcXrA==", "b682288c-f2a1-4cb6-9f0b-bcf609dafb06", null });
        }
    }
}
