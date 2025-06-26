using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Ward
    {
        [Key]
        public int WardId { get; set; }

        [Required]
        public string WardName { get; set; }

        //public ICollection<PatientRegistration> PatientRegistrations { get; set; }
    }
}
