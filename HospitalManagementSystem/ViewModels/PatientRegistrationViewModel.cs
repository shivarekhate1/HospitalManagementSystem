using HospitalManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HospitalManagementSystem.ViewModels
{
    public class PatientRegistrationViewModel
    {
        public PatientRegistration? patientRegistration { get; set; }
        public List<SelectListItem>? PatientTypeList { get; set; }
    }
}
