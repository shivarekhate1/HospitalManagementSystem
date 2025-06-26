using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace HospitalManagementSystem.Models
{
    public class PatientRegistration
    {
        [Key]
        public int PatientId { get; set; }

        [Required, StringLength(50)]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Name can only contain letters and spaces.")]
        public string? FirstName { get; set; }

        [Required, StringLength(50)]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Name can only contain letters and spaces.")]
        public string? FatherName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required(ErrorMessage = "Select Your Gender")]
        public string? Gender { get; set; }

        [Required(ErrorMessage = "Mobile Number is required")]
        public string? PhoneNumber { get; set; }

        [Required]
        public string? Address { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public int BloodGroupId { get; set; }
        [ForeignKey("BloodGroupId")]
        public BloodGroup BloodGroup { get; set; }
        [ForeignKey("WardId")]
        public int WardId { get; set; }
        public Ward Ward { get; set; }
        [ForeignKey("DiseaseTypeId")]

        public int DiseaseTypeId { get; set; }
        public DiseaseType DiseaseType { get; set; }
        [ForeignKey("DoctorId")]
        public int DoctorName { get; set; }
        //public Doctor Doctor { get; set; }
    }
}
