using AutoMapper;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Mapping
{
    public class MappingPatientRegistration : Profile
    {
        public MappingPatientRegistration()
        {
            CreateMap<PatientRegistration, PatientRegistrationDto>().ReverseMap();
        }
    }
}
