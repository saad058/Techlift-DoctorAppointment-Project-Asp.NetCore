using DoctorAppointment.Models;
using DoctorAppointment.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointment.Controllers
{
    public class EmailController : Controller
    {
        private readonly IMailService _service;
        /// <summary>
        ///     dependency injection 
        /// </summary>
        /// <param></param>
        public EmailController(IMailService service)
        {
            _service = service;
        }
        public IActionResult Send()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Send(MailContent mail)
        {
            _service.sendEmail(mail);
            return View();
        }
    }
}
