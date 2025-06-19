using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Patienttypeadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PatientType",
                table: "patientRegistrations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientTypeDetailsPatientTypeId",
                table: "patientRegistrations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_patientRegistrations_PatientTypeDetailsPatientTypeId",
                table: "patientRegistrations",
                column: "PatientTypeDetailsPatientTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_patientRegistrations_patientTypes_PatientTypeDetailsPatientTypeId",
                table: "patientRegistrations",
                column: "PatientTypeDetailsPatientTypeId",
                principalTable: "patientTypes",
                principalColumn: "PatientTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patientRegistrations_patientTypes_PatientTypeDetailsPatientTypeId",
                table: "patientRegistrations");

            migrationBuilder.DropIndex(
                name: "IX_patientRegistrations_PatientTypeDetailsPatientTypeId",
                table: "patientRegistrations");

            migrationBuilder.DropColumn(
                name: "PatientType",
                table: "patientRegistrations");

            migrationBuilder.DropColumn(
                name: "PatientTypeDetailsPatientTypeId",
                table: "patientRegistrations");
        }
    }
}
