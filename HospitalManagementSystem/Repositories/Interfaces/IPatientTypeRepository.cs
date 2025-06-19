using HospitalManagementSystem.Models;

public interface IPatientTypeRepository
{
    Task<IEnumerable<PatientType>> GetAllAsync();
    Task<PatientType?> GetByIdAsync(int id);
}
