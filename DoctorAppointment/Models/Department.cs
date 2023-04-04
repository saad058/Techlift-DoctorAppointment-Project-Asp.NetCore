using DoctorAppointment.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DoctorAppointment.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Depart cannot be null")]
        public string DepartmentName { get; set; }

        public ICollection<DoctorInfo> Doctors { get; set; }

    }
}
