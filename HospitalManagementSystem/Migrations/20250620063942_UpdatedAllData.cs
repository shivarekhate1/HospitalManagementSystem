using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedAllData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patientRegistrations_patientTypes_PatientTypeDetailsPatientTypeId",
                table: "patientRegistrations");

            migrationBuilder.RenameColumn(
                name: "PatientTypeDetailsPatientTypeId",
                table: "patientRegistrations",
                newName: "PatientTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_patientRegistrations_PatientTypeDetailsPatientTypeId",
                table: "patientRegistrations",
                newName: "IX_patientRegistrations_PatientTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_patientRegistrations_patientTypes_PatientTypeId",
                table: "patientRegistrations",
                column: "PatientTypeId",
                principalTable: "patientTypes",
                principalColumn: "PatientTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patientRegistrations_patientTypes_PatientTypeId",
                table: "patientRegistrations");

            migrationBuilder.RenameColumn(
                name: "PatientTypeId",
                table: "patientRegistrations",
                newName: "PatientTypeDetailsPatientTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_patientRegistrations_PatientTypeId",
                table: "patientRegistrations",
                newName: "IX_patientRegistrations_PatientTypeDetailsPatientTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_patientRegistrations_patientTypes_PatientTypeDetailsPatientTypeId",
                table: "patientRegistrations",
                column: "PatientTypeDetailsPatientTypeId",
                principalTable: "patientTypes",
                principalColumn: "PatientTypeId");
        }
    }
}
