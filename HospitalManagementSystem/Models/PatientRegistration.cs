using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class PatientRegistration
    {
        [Key]
        public int PatientId { get; set; }
        [ForeignKey("PatientType")]
        public string? PatientType { get; set; }
        public PatientType? PatientTypeDetails { get; set; }


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

        [Required(ErrorMessage = "Please select your Blood Group")]
        public string BloodGroup { get; set; }
        [Required(ErrorMessage = "Please select your Ward Name")]
        public String? WardName { get; set; }
        [Required(ErrorMessage = "Please select your Disease Type")]
        public string? DiseaseType { get; set; }
        [Required(ErrorMessage = "Please select your Doctor Name")]
        public string? DoctorName { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.Now;


    }
}
