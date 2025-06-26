using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        [Required]
        public string DoctorName { get; set; }

        //public ICollection<PatientRegistration> PatientRegistrations { get; set; }
    }
}
