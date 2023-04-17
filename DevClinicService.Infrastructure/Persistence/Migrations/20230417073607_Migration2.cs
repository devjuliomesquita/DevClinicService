using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevClinicService.Infrastructure.Persistence.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specialties_Users_UserId",
                table: "Specialties");

            migrationBuilder.DropIndex(
                name: "IX_Specialties_UserId",
                table: "Specialties");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Specialties");

            migrationBuilder.CreateIndex(
                name: "IX_Specialties_IdUser",
                table: "Specialties",
                column: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Specialties_Users_IdUser",
                table: "Specialties",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specialties_Users_IdUser",
                table: "Specialties");

            migrationBuilder.DropIndex(
                name: "IX_Specialties_IdUser",
                table: "Specialties");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Specialties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Specialties_UserId",
                table: "Specialties",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Specialties_Users_UserId",
                table: "Specialties",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
