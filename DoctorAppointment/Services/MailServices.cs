using DoctorAppointment.Configuration;
using DoctorAppointment.Models;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;
using System;

namespace DoctorAppointment.Services
{
    public class MailServices : IMailService
    {
        private readonly EmailSettings _settings;
        //dependecy injection email setting in this class
        //dependency injection is injected in constructor of class
        public MailServices(IOptions<EmailSettings> setting)
        {
            _settings = setting.Value;  
        }
        public bool sendEmail(MailContent messagebody)
        {
            try
            {
                MimeMessage mail = new MimeMessage();
                mail.From.Add(new MailboxAddress(_settings.DisplayName, _settings.FromEmailAddress));
                mail.To.Add(MailboxAddress.Parse(messagebody.ToEmailAddress));
                mail.Subject = messagebody.EmailSubject;
                //Well use another class to compose email body 

                BodyBuilder body = new BodyBuilder();
                body.HtmlBody = messagebody.EmailBody;

                //body builder ki class just email body key liye use karte hain 
                // aur usey again mail ki class main pass kar detey hain

                mail.Body = body.ToMessageBody();

                //SMTP class
                using (SmtpClient client = new SmtpClient()) //using ka sccope resources ko free kr ka nikalta ha 
                {
                    client.Connect(_settings.HOST, _settings.PORT, MailKit.Security.SecureSocketOptions.StartTls);
                    client.Authenticate(_settings.FromEmailAddress, _settings.Password);
                    client.Send(mail);
                }
                //resources free
                return true;

            }
            catch(Exception ex)
            {
                return false;
            }
           
        }
    }
}
