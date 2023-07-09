using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac2e8c7-5ad6-43e5-baaf-a332c9322a8c",
                column: "ConcurrencyStamp",
                value: "bd94d178-65c0-45cf-96b9-b0cf82cb207a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfd2e8c7-5ad4-43e5-deaf-a332c9322a8r",
                column: "ConcurrencyStamp",
                value: "2a65b68c-cc45-4ba6-bdd3-512d271b034b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c532e8c6-5fd6-43e5-baaf-a332c9322a9d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "418ea849-de74-4c2b-9f1c-6a800c2c37a6", "AQAAAAEAACcQAAAAEHw+oXrYlCl+x/uKroYpLlDpr4DmvUgl+tSCbiOsEiJXD462yDwmzi1BxpNAzXko6Q==", "108e2938-ba60-49ee-b745-b8f9e16fae66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4425472-79e5-4da5-832e-1e43ad0bcd97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9494f12-8c75-4d8e-9205-5772d74d1b9c", "AQAAAAEAACcQAAAAEE+ErA7vMbeuOc+uHHc9gGSfBAvoWF/hNvdu7gvL5c+4Wx8HpAKx5d7GxH3FtPnf+g==", "603fe9b9-6334-4f61-9168-a759894d4b6c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b463bb5-ff14-4f25-aee7-4be76a15a307", "AQAAAAEAACcQAAAAEOTCj+/cFT/aFkxtjy63aDDZN2Vxq9rpsYREqnWQW4XZhxtxeeXakQ+FL44xkhMoBQ==", "b4adb9d3-698a-43c2-8e1a-6103e8fea903" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4425472-79e5-4da5-832e-1e43ad0bcd97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "132936ac-8196-487e-8879-bf2814124f97", "AQAAAAEAACcQAAAAEFBLwKrYVEXxKYS9E6WkS0mMuh3kcaKuc5ZOqNz0xDbkt5p9Q9Gm/CCn+Zn+uGpHsw==", "dbf2f8a5-99c4-4386-b86a-96b8feedc535" });
        }
    }
}
