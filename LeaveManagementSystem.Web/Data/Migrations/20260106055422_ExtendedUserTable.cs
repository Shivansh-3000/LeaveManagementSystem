using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "460323e9-926b-4715-ac84-cf2f410b37dc",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3221cac-f787-40e2-85ab-ec4b690b2817", new DateOnly(2002, 5, 27), "Default", "Admin", "AQAAAAIAAYagAAAAEMDVA2npHnjCkFe5V/+ToYFq10eNMJTsOR53AhH/VxHIjobont01+yqLJaBkIBT4RA==", "cc34b592-4e20-4434-af39-eefc79329e2e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "460323e9-926b-4715-ac84-cf2f410b37dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04c22f3c-b1e7-40d4-ab0d-c95fcf3f42ac", "AQAAAAIAAYagAAAAEEiLpuvUqrGjeoYtC0epIifQB21aHs85hLup9UQUsixM8Z4GcGoStIfyPMLqNJ0TYg==", "3a37e903-65de-4421-95a0-8d6a86ed7f0b" });
        }
    }
}
