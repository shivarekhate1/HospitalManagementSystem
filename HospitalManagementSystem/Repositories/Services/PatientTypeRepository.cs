using HospitalManagementSystem.Data;
using HospitalManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

public class PatientTypeRepository : IPatientTypeRepository
{
    private readonly HospitalDbContext _context;

    public PatientTypeRepository(HospitalDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<PatientType>> GetAllAsync()
    {
        return await _context.patientTypes.ToListAsync();
    }

    public async Task<PatientType?> GetByIdAsync(int id)
    {
        return await _context.patientTypes.FindAsync(id);
    }
}
