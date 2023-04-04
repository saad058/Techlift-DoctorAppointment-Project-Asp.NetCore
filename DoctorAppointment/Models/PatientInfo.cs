using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

namespace DoctorAppointment.Models
{
    public class PatientInfo:BaseClass
    {
        [Key]
        public int PatientId { get; set; }
        [Display(Name = "History")]
       // [AllowNull]
        //[Required(ErrorMessage = "History is required")]
        public string? PatientHistory { get; set; }
    }
}
