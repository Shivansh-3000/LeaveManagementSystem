using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesandUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "72edfa20-2eab-4633-8704-8dfc6ed15847", null, "Supervisor", "SUPERVISOR" },
                    { "bc728aba-918b-45fb-8f4f-4cb7833fe630", null, "Employee", "EMPLOYEE" },
                    { "eb3cbaff-7f32-471e-ae1f-12ee4fb1a529", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "460323e9-926b-4715-ac84-cf2f410b37dc", 0, "04c22f3c-b1e7-40d4-ab0d-c95fcf3f42ac", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEEiLpuvUqrGjeoYtC0epIifQB21aHs85hLup9UQUsixM8Z4GcGoStIfyPMLqNJ0TYg==", null, false, "3a37e903-65de-4421-95a0-8d6a86ed7f0b", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "eb3cbaff-7f32-471e-ae1f-12ee4fb1a529", "460323e9-926b-4715-ac84-cf2f410b37dc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72edfa20-2eab-4633-8704-8dfc6ed15847");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc728aba-918b-45fb-8f4f-4cb7833fe630");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eb3cbaff-7f32-471e-ae1f-12ee4fb1a529", "460323e9-926b-4715-ac84-cf2f410b37dc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb3cbaff-7f32-471e-ae1f-12ee4fb1a529");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "460323e9-926b-4715-ac84-cf2f410b37dc");
        }
    }
}
