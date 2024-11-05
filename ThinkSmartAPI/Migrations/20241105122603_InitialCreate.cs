using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThinkSmartAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    StudentCode = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentExtension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentDateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentAge = table.Column<int>(type: "int", nullable: true),
                    StudentGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentAddress3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentAddress4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentGuardianName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentGuardianContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentGuardianEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentEmergencyContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentEmergencyContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Allergies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalConditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialNeeds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    UserCode = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordResetToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TokenExpiry = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
