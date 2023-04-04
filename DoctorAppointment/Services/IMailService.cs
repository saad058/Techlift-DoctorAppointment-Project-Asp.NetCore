using DoctorAppointment.Models;
using DoctorAppointment.Configuration;
namespace DoctorAppointment.Services
{
    public interface IMailService
    {
        bool sendEmail(MailContent messagebody);
    }
}
