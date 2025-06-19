using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using HospitalManagementSystem.Data;

namespace HospitalManagementSystem.Data
{
    public class HospitalDbContextFactory : IDesignTimeDbContextFactory<HospitalDbContext>
    {
        public HospitalDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<HospitalDbContext>();

            var connectionString = "Server=BALIDAN\\SQLEXPRESS;Database=HospitalDb;Trusted_Connection=True;TrustServerCertificate=True;";

            optionsBuilder.UseSqlServer(connectionString);

            return new HospitalDbContext(optionsBuilder.Options);
        }
    }
}
