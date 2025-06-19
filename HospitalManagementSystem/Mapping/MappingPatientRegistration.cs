using AutoMapper;
using HospitalManagementSystem.DTOs;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Mapping
{
    public class MappingPatientRegistration : Profile
    {
        public MappingPatientRegistration()
        {
            CreateMap<PatientRegistration, PatientRegistrationDTOs>().ReverseMap();
        }
    }
}
