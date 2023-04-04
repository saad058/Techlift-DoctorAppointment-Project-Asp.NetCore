using System.ComponentModel.DataAnnotations;

namespace DoctorAppointment.Models
{
    public class MailContent
    {
        [Key]
        public int Id { get; set; }
        public string ToEmailAddress { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
    }
}
