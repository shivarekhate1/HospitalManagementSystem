using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class BloodGroup
    {
        [Key]
        public int BloodGroupId { get; set; }

        [Required]
        public string GroupName { get; set; }

        //public ICollection<PatientRegistration> PatientRegistrations { get; set; }
    }
}
