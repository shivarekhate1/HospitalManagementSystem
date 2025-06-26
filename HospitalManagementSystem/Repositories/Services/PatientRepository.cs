using HospitalManagementSystem.Data;
using HospitalManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public class PatientRepository : IPatientRepository
{
    private readonly HospitalDbContext _context;

    public PatientRepository(HospitalDbContext context)
    {
        _context = context;
    }

    public async Task<PatientRegistration> AddPatientAsync(PatientRegistrationDto dto)
    {
        var patientType = await _context.patientTypes
            .FirstOrDefaultAsync(pt => pt.PatientTypeName == dto.PatientTypeName);
        if (patientType == null)
        {
            patientType = new PatientType { PatientTypeName = dto.PatientTypeName };
            _context.patientTypes.Add(patientType);
            await _context.SaveChangesAsync();
        }

        var bloodGroup = await _context.BloodGroups
            .FirstOrDefaultAsync(bg => bg.GroupName == dto.BloodGroup);
        if (bloodGroup == null)
        {
            bloodGroup = new BloodGroup { GroupName = dto.BloodGroup };
            _context.BloodGroups.Add(bloodGroup);
            await _context.SaveChangesAsync();
        }

        var ward = await _context.Wards
            .FirstOrDefaultAsync(w => w.WardName == dto.WardName);
        if (ward == null)
        {
            ward = new Ward { WardName = dto.WardName };
            _context.Wards.Add(ward);
            await _context.SaveChangesAsync();
        }

        var disease = await _context.DiseaseTypes
            .FirstOrDefaultAsync(d => d.DiseaseName == dto.DiseaseType);
        if (disease == null)
        {
            disease = new DiseaseType { DiseaseName = dto.DiseaseType };
            _context.DiseaseTypes.Add(disease);
            await _context.SaveChangesAsync();
        }

        var doctor = await _context.Doctors
            .FirstOrDefaultAsync(d => d.DoctorName == dto.DoctorName);
        if (doctor == null)
        {
            doctor = new Doctor { DoctorName = dto.DoctorName };
            _context.Doctors.Add(doctor);
            await _context.SaveChangesAsync();
        }

        var patient = new PatientRegistration
        {
            PatientId = patientType.PatientTypeId,
            FirstName = dto.FirstName,
            FatherName = dto.FatherName,
            Age = dto.Age,
            Gender = dto.Gender,
            PhoneNumber = dto.PhoneNumber,
            Address = dto.Address,
            BloodGroupId = bloodGroup.BloodGroupId,
            WardId = ward.WardId,
            DiseaseTypeId = disease.DiseaseTypeId,
            DoctorName = doctor.DoctorId,
            RegistrationDate = dto.RegistrationDate
        };

        _context.patientRegistrations.Add(patient);
        await _context.SaveChangesAsync();

        return patient;
    }
}
