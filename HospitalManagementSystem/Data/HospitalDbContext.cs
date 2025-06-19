

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
    }
}
