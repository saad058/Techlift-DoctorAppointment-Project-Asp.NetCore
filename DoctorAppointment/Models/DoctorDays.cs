using System;
using System.ComponentModel.DataAnnotations;

namespace DoctorAppointment.Models
{
    public class DoctorDays
    {
        [Key]
        public int ScheduleId { get; set; }//doctorinfo ki foreign key 
        public int DoctorId { get; set; }
        public string DoctorFirstName { get; set; }
        public string DoctorLasatName { get; set; }
        public int DepartmentId { get; set; }
        public string DoctorDay { get; set; }
        public DateTime DoctorDate { get; set; }
        public bool IsAvailable { get; set;}
        

    }
}
