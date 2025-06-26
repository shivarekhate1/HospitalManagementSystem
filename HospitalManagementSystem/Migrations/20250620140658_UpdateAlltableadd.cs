using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAlltableadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patientRegistrations_patientTypes_PatientTypeId",
                table: "patientRegistrations");

            migrationBuilder.DropColumn(
                name: "BloodGroup",
                table: "patientRegistrations");

            migrationBuilder.DropColumn(
                name: "DiseaseType",
                table: "patientRegistrations");

            migrationBuilder.DropColumn(
                name: "DoctorName",
                table: "patientRegistrations");

            migrationBuilder.DropColumn(
                name: "WardName",
                table: "patientRegistrations");

            migrationBuilder.AlterColumn<int>(
                name: "PatientTypeId",
                table: "patientRegistrations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BloodGroupId",
                table: "patientRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DiseaseTypeId",
                table: "patientRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "patientRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WardId",
                table: "patientRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BloodGroups",
                columns: table => new
                {
                    BloodGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodGroups", x => x.BloodGroupId);
                });

            migrationBuilder.CreateTable(
                name: "DiseaseTypes",
                columns: table => new
                {
                    DiseaseTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiseaseName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseTypes", x => x.DiseaseTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorId);
                });

            migrationBuilder.CreateTable(
                name: "Wards",
                columns: table => new
                {
                    WardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WardName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wards", x => x.WardId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_patientRegistrations_BloodGroupId",
                table: "patientRegistrations",
                column: "BloodGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_patientRegistrations_DiseaseTypeId",
                table: "patientRegistrations",
                column: "DiseaseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_patientRegistrations_DoctorId",
                table: "patientRegistrations",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_patientRegistrations_WardId",
                table: "patientRegistrations",
                column: "WardId");

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

            migrationBuilder.DropForeignKey(
                name: "FK_patientRegistrations_patientTypes_PatientTypeId",
                table: "patientRegistrations");

            migrationBuilder.DropTable(
                name: "BloodGroups");

            migrationBuilder.DropTable(
                name: "DiseaseTypes");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Wards");

            migrationBuilder.DropIndex(
                name: "IX_patientRegistrations_BloodGroupId",
                table: "patientRegistrations");

            migrationBuilder.DropIndex(
                name: "IX_patientRegistrations_DiseaseTypeId",
                table: "patientRegistrations");

            migrationBuilder.DropIndex(
                name: "IX_patientRegistrations_DoctorId",
                table: "patientRegistrations");

            migrationBuilder.DropIndex(
                name: "IX_patientRegistrations_WardId",
                table: "patientRegistrations");

            migrationBuilder.DropColumn(
                name: "BloodGroupId",
                table: "patientRegistrations");

            migrationBuilder.DropColumn(
                name: "DiseaseTypeId",
                table: "patientRegistrations");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "patientRegistrations");

            migrationBuilder.DropColumn(
                name: "WardId",
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

            migrationBuilder.AddColumn<string>(
                name: "BloodGroup",
                table: "patientRegistrations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DiseaseType",
                table: "patientRegistrations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DoctorName",
                table: "patientRegistrations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WardName",
                table: "patientRegistrations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_patientRegistrations_patientTypes_PatientTypeId",
                table: "patientRegistrations",
                column: "PatientTypeId",
                principalTable: "patientTypes",
                principalColumn: "PatientTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
