using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Repositories.Interfaces
{
    public interface IPatientTypeService
    {
        Task<IEnumerable<PatientType>> GetAllAsync();
    }
}
