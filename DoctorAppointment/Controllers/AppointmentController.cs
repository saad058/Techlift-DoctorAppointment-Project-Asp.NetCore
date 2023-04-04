using DoctorAppointment.Data;
using DoctorAppointment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Web;

namespace DoctorAppointment.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly MyContext _context;
        public AppointmentController(MyContext context) 
        {
            _context = context;
        }
        public IActionResult BookAppointment()
        {
            var departments =   _context.tblDepartments.Select(d => d.DepartmentName).Distinct().ToList();
            ViewBag.Departments = departments;
            return View();
        }
        
        public IActionResult DepartmentbyID(int DepartId)
        {
            return View(_context.tblDoctor.Where(a => a.DepartmentId == DepartId).ToList());
        }

        [HttpPost]
        public IActionResult Add(Appointment ap)
        {
            _context.tblAppointment.Add(ap);
            _context.SaveChanges();
            return RedirectToAction("BookAppointment", "Appointment");
           // return View(_context.tblDoctor.Where(a => a.DepartmentId == DepartId).ToList());
        }

        public IActionResult Check(string department)
        {
            // Retrieve the list of appointments from your data source,
            // filtered by the selected department (if any)

            //  IQueryable<DocotorInfo> appointments = _context.tblDoctor;
            //if (!string.IsNullOrEmpty(department))
            //{
            //   // appointments = appointments.Where(a => a.Department == department);
            //}

            // Retrieve the department object for the selected department
            var selectedDepartment = _context.tblDepartments
                .Include(d => d.Doctors)
                .FirstOrDefault(d => d.DepartmentName == department);

            // Retrieve the list of doctors for the selected department
            var doctors = selectedDepartment?.Doctors?.ToList();

            // Create a view model to pass the appointments and department
            // information to the view
            //var viewModel = new AppointmentViewModel
            //{
            //    Appointments = doctors.ToList(),
            //    Department = department,
            //    Doctors = doctors
            //};

            // Pass the view model to the view
            // return View(viewModel);
            return View(doctors);
       }

        public IActionResult Create()
        {
           // var departments = _context.tblDepartments.Select(d => d.DepartmentName).Distinct().ToList();
           // ViewBag.Departments = departments;
            return View();
        }

        public IActionResult BookApppointmentByPatient()
        {
          var patID=   HttpContext.Session.GetString("Patient");
           // dateofweek
           // HttpContext.Session.GetString("dateofweek");
            HttpContext.Session.SetString("PtID", patID); ;
            //var Getrole = Context.Session.GetString("Patient");
            // var departments = _context.tblDepartments.Select(d => d.DepartmentName).Distinct().ToList();
            // ViewBag.Departments = departments;
            return View();
        }

    }
}



