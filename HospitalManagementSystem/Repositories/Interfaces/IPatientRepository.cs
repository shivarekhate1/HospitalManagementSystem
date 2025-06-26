using HospitalManagementSystem.Models;

public interface IPatientRepository
{
    Task<PatientRegistration> AddPatientAsync(PatientRegistrationDto dto);
}
