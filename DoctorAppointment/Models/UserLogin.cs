using System.ComponentModel.DataAnnotations;

namespace DoctorAppointment.Models
{
    public class UserLogin
    {
        [Key]
        public int ID { get; set; }
        public string LoginEmail { get; set; }

        public string Password { get; set; }

        public string UserRole { get; set; }
    }
}
