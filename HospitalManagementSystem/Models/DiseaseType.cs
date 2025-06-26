using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class DiseaseType
    {
        [Key]
        public int DiseaseTypeId { get; set; }

        [Required]
        public string DiseaseName { get; set; }

        //public ICollection<PatientRegistration> PatientRegistrations { get; set; }
    }
}
