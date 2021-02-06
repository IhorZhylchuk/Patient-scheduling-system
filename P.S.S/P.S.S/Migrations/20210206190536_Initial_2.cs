using Microsoft.EntityFrameworkCore.Migrations;

namespace P.S.S.Migrations
{
    public partial class Initial_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations");

            migrationBuilder.RenameTable(
                name: "Reservations",
                newName: "ReservationModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservationModel",
                table: "ReservationModel",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "337be81d-29f7-4b90-883b-d9110b3b3a83");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "62e6992f-d3c8-49cd-aafd-d6f32cee0b03", "AQAAAAEAACcQAAAAEOy001QDyLHUZmhPAyIWsowAMj0o+VBHnQfplPfcVAJ8Ma3tfyOTzEVKa9HjuQtFXg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservationModel",
                table: "ReservationModel");

            migrationBuilder.RenameTable(
                name: "ReservationModel",
                newName: "Reservations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "f2ba59a4-65f7-4033-92a1-3d12500c476c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7934db7-ee4c-4356-8c1b-a35f0290081d", "AQAAAAEAACcQAAAAEOeTU6JOLerMsLJUemSJ1ts94YLHB5WpBJM4fFOLiYOnFcWFNa7SqsQwodnry4mYRQ==" });
        }
    }
}
