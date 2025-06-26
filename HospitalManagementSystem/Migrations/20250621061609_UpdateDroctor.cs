using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDroctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patientRegistrations_Doctors_DoctorId",
                table: "patientRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_patientRegistrations_patientTypes_PatientTypeId",
                table: "patientRegistrations");

            migrationBuilder.DropIndex(
                name: "IX_patientRegistrations_DoctorId",
                table: "patientRegistrations");

            migrationBuilder.DropIndex(
                name: "IX_patientRegistrations_PatientTypeId",
                table: "patientRegistrations");

            migrationBuilder.DropColumn(
                name: "PatientTypeId",
                table: "patientRegistrations");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "patientRegistrations",
                newName: "DoctorName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DoctorName",
                table: "patientRegistrations",
                newName: "DoctorId");

            migrationBuilder.AddColumn<int>(
                name: "PatientTypeId",
                table: "patientRegistrations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_patientRegistrations_DoctorId",
                table: "patientRegistrations",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_patientRegistrations_PatientTypeId",
                table: "patientRegistrations",
                column: "PatientTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_patientRegistrations_Doctors_DoctorId",
                table: "patientRegistrations",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_patientRegistrations_patientTypes_PatientTypeId",
                table: "patientRegistrations",
                column: "PatientTypeId",
                principalTable: "patientTypes",
                principalColumn: "PatientTypeId");
        }
    }
}
