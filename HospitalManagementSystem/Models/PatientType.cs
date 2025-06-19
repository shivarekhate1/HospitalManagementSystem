using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class PatientType
    {
        [Key]
        public int PatientTypeId { get; set; }
        [Required(ErrorMessage = "Patient Type Name is required")]  
        public string? PatientTypeName { get; set; }
        public ICollection<PatientRegistration>? PatientRegistrations { get; set; }
    }
}
