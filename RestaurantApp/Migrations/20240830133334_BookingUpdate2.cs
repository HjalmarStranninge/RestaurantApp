using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantApp.Migrations
{
    /// <inheritdoc />
    public partial class BookingUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Tables");

            migrationBuilder.RenameColumn(
                name: "DateTimeOfBooking",
                table: "Bookings",
                newName: "StartDateTime");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDateTime",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDateTime",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "StartDateTime",
                table: "Bookings",
                newName: "DateTimeOfBooking");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Tables",
                type: "bit",
                nullable: false,
                defaultValue: true);
        }
    }
}
