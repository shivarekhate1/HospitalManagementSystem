using HospitalManagementSystem.Models;
using HospitalManagementSystem.Repositories.Interfaces;

public class PatientTypeService : IPatientTypeService
{
    private readonly IPatientTypeRepository _repository;

    public PatientTypeService(IPatientTypeRepository repository)
    {
        _repository = repository;
    }

    public Task<IEnumerable<PatientType>> GetAllAsync()
    {
        return _repository.GetAllAsync();
    }
}
