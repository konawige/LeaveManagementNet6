using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Canceled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac2e8c7-5ad6-43e5-baaf-a332c9322a8c",
                column: "ConcurrencyStamp",
                value: "2e4f612c-567e-4e13-ad36-13b5f882c82a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfd2e8c7-5ad4-43e5-deaf-a332c9322a8r",
                column: "ConcurrencyStamp",
                value: "f2d6cae8-7221-4142-9d58-86589b36f2df");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c532e8c6-5fd6-43e5-baaf-a332c9322a9d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38919cc5-c98c-4237-bcad-0de61da582e4", "AQAAAAEAACcQAAAAEEDaWlRLPUgCGIKF+sJt6eyU4kFyp0RB/ZGuh3YVIE/lCCxQzF+FtbnYpMtr3AitGw==", "506c7f5d-8d45-48fb-b410-346c880f3a45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4425472-79e5-4da5-832e-1e43ad0bcd97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9b90e08-7542-4e37-99f6-d7de9a688aae", "AQAAAAEAACcQAAAAEKK/ayPhH/EhLI9/Y/rJJ/EaOHirFybsqYt3Wqf0U/R9BTKiCydRNzUCQKidq3fd6g==", "453f7ace-34b9-43ee-a77a-b68f2c814d07" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
