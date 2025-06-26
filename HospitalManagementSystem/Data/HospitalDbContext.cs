

using HospitalManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Data
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options)
            : base(options)
        {

        }
        public DbSet<PatientRegistration> patientRegistrations { get; set; }
        public DbSet<PatientType> patientTypes { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<DiseaseType> DiseaseTypes { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
    }
}
