using Microsoft.AspNetCore.Mvc;
using DoctorAppointment.Controllers;
using DoctorAppointment.Models;
using DoctorAppointment.Data;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace DoctorAppointment.Controllers
{
    public class UserLoginController : Controller
    {
        private readonly MyContext _context; //Local variabl
        public UserLoginController(MyContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            UserLogin uselog= new UserLogin();
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserLogin user)
        {
            var user1 = _context.tblUser.SingleOrDefault(m => m.LoginEmail == user.LoginEmail && m.Password == user.Password);

            if (user1 == null)
            {
                return View(user);
            }

            HttpContext.Session.SetString("Username", user.LoginEmail);
            HttpContext.Session.SetString("Password", user.Password);

            switch (user1.UserRole)
            {
                case "admin":
                    return RedirectToAction("Admin", "Admin");

                case "Patient":
                    return RedirectToAction("Create", "DoctorInfoes");

                default:
                    return RedirectToAction("BookAppointment", "Appointment");
            }
        }
        public IActionResult SuccessPage()
        {
            return View();
        }


        public IActionResult CustomLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CustomLogin(UserLogin user)
        {
            var user1 = _context.tblUser.SingleOrDefault(m => m.LoginEmail == user.LoginEmail && m.Password == user.Password);
           // var userRole= user1.UserRole;
            if (user1 == null)
            {
                return View(user);
            }

            HttpContext.Session.SetString("UserEmail", user.LoginEmail);
            HttpContext.Session.SetString("Password", user.Password);

            switch (user1.UserRole)
            {
                case "Admin":
                    ViewBag.Role = "Admin";
                    TempData["Role"] = ViewBag.Role;
                    HttpContext.Session.SetString("Role", "Admin");
                    return RedirectToAction("Index", "DoctorInfoes1");

                case "Patient":
                    
                    ViewBag.Role = "Patient";
                    TempData["Role"] = ViewBag.Role;
                    HttpContext.Session.SetString("Role", "Patient");
                    return RedirectToAction("Index", "PatientInfoes");

                case "Doctor":
                    ViewBag.Role = "Doctor";
                    TempData["Role"] = ViewBag.Role;
                    HttpContext.Session.SetString("Role","Doctor");
                    return RedirectToAction("Index", "DoctorInfoes1");

                default:
                    return RedirectToAction("BookAppointment", "Appointment");
            }
           // return View();
        }


        public IActionResult CheckLayout()
        {
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("CustomLogin");
        }

    }
}
