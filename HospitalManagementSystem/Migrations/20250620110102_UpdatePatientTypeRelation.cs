using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePatientTypeRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patientRegistrations_patientTypes_PatientTypeId",
                table: "patientRegistrations");

            migrationBuilder.DropColumn(
                name: "PatientType",
                table: "patientRegistrations");

            migrationBuilder.AlterColumn<int>(
                name: "PatientTypeId",
                table: "patientRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_patientRegistrations_patientTypes_PatientTypeId",
                table: "patientRegistrations",
                column: "PatientTypeId",
                principalTable: "patientTypes",
                principalColumn: "PatientTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patientRegistrations_patientTypes_PatientTypeId",
                table: "patientRegistrations");

            migrationBuilder.AlterColumn<int>(
                name: "PatientTypeId",
                table: "patientRegistrations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "PatientType",
                table: "patientRegistrations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_patientRegistrations_patientTypes_PatientTypeId",
                table: "patientRegistrations",
                column: "PatientTypeId",
                principalTable: "patientTypes",
                principalColumn: "PatientTypeId");
        }
    }
}
