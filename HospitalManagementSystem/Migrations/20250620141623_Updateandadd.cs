using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Updateandadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patientRegistrations_BloodGroups_BloodGroupId",
                table: "patientRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_patientRegistrations_DiseaseTypes_DiseaseTypeId",
                table: "patientRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_patientRegistrations_Doctors_DoctorId",
                table: "patientRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_patientRegistrations_Wards_WardId",
                table: "patientRegistrations");

            migrationBuilder.AlterColumn<int>(
                name: "WardId",
                table: "patientRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "patientRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DiseaseTypeId",
                table: "patientRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BloodGroupId",
                table: "patientRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_patientRegistrations_BloodGroups_BloodGroupId",
                table: "patientRegistrations",
                column: "BloodGroupId",
                principalTable: "BloodGroups",
                principalColumn: "BloodGroupId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_patientRegistrations_DiseaseTypes_DiseaseTypeId",
                table: "patientRegistrations",
                column: "DiseaseTypeId",
                principalTable: "DiseaseTypes",
                principalColumn: "DiseaseTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_patientRegistrations_Doctors_DoctorId",
                table: "patientRegistrations",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_patientRegistrations_Wards_WardId",
                table: "patientRegistrations",
                column: "WardId",
                principalTable: "Wards",
                principalColumn: "WardId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patientRegistrations_BloodGroups_BloodGroupId",
                table: "patientRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_patientRegistrations_DiseaseTypes_DiseaseTypeId",
                table: "patientRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_patientRegistrations_Doctors_DoctorId",
                table: "patientRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_patientRegistrations_Wards_WardId",
                table: "patientRegistrations");

            migrationBuilder.AlterColumn<int>(
                name: "WardId",
                table: "patientRegistrations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "patientRegistrations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DiseaseTypeId",
                table: "patientRegistrations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BloodGroupId",
                table: "patientRegistrations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_patientRegistrations_BloodGroups_BloodGroupId",
                table: "patientRegistrations",
                column: "BloodGroupId",
                principalTable: "BloodGroups",
                principalColumn: "BloodGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_patientRegistrations_DiseaseTypes_DiseaseTypeId",
                table: "patientRegistrations",
                column: "DiseaseTypeId",
                principalTable: "DiseaseTypes",
                principalColumn: "DiseaseTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_patientRegistrations_Doctors_DoctorId",
                table: "patientRegistrations",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_patientRegistrations_Wards_WardId",
                table: "patientRegistrations",
                column: "WardId",
                principalTable: "Wards",
                principalColumn: "WardId");
        }
    }
}
