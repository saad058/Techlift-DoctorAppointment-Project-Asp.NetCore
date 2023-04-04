using System;
using System.ComponentModel.DataAnnotations;
namespace DoctorAppointment.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentID { get; set; }
        public string AppointmentDate { get; set; } 
        public int PatID { get; set; }
        public int DocID { get; set; }
        public string AppointmentDay { get; set; }

    }
}
