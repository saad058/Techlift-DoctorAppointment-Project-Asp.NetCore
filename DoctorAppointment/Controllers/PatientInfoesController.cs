using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoctorAppointment.Models;
using DoctorAppointment.Data;
using DoctorAppointment.Models.MVVM;
using Microsoft.AspNetCore.Http;

namespace DoctorAppointment.Controllers
{
   
    public class PatientInfoesController : Controller
    {
        private readonly MyContext _context;

        public PatientInfoesController(MyContext context)
        {
            _context = context;
        }

        // GET: PatientInfoes


        public IActionResult RegisterPatient()
        {
            return View();
            // Problem("Entity set 'MyContext.PatientInfo'  is null.");
        }

        [HttpPost]
        public IActionResult RegisterPatient(PatientVM model)
        {
            if (ModelState.IsValid)
            {
                var patient = new PatientInfo
                {
                    First_Name = model.FirstName,
                    Last_Name = model.LastName,
                    EmailAddress = model.PatientEmail
                };

                // Add the patient to the database
                _context.tblPatients.Add(patient);
                _context.SaveChanges();

                // Create a new UserLogin object
                var user = new UserLogin
                {
                    LoginEmail = model.PatientEmail,
                    Password = model.Password,
                    UserRole = "Patient"
                };

                // Add the user to the database
                _context.tblUser.Add(user);
                _context.SaveChanges();

                // Do something with the validated model data
                // e.g. save it to the database

                // Redirect to a success page
                return RedirectToAction("CustomLogin", "UserLogin");
            }

            // If the model state is not valid, return the view with the invalid model
            return View(model);
        }

        [CustomAuthorizeAttribute("Admin", "Doctor", "Patient")]
        public IActionResult Index()
        {

            string UserRole = HttpContext.Session.GetString("Role");

            if (UserRole == "Patient")
            {
                string userEmail = HttpContext.Session.GetString("UserEmail");
                var patient =  _context.tblPatients.Where(p => p.EmailAddress == userEmail);

                var pateintid = patient.FirstOrDefault().PatientId;
               
              HttpContext.Session.SetString("Patient", pateintid.ToString());
                return View(patient);
            }

            else { 

            return View(_context.tblPatients.ToList());

            }
            // Problem("Entity set 'MyContext.PatientInfo'  is null.");
        }

        [CustomAuthorizeAttribute("Admin", "Doctor", "Patient")]
        // GET: PatientInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.tblPatients == null)
            {
                return NotFound();
            }

            var patientInfo = await _context.tblPatients
                .FirstOrDefaultAsync(m => m.PatientId == id);
            if (patientInfo == null)
            {
                return NotFound();
            }

            return View(patientInfo);
        }

        // GET: PatientInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PatientInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [CustomAuthorizeAttribute("Admin","Patient")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PatientId,PatientHistory,First_Name,Last_Name,EmailAddress,ContactNumber,HomeAddress")] PatientInfo patientInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(patientInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(patientInfo);
        }

        [CustomAuthorizeAttribute("Admin", "Patient")]
        // GET: PatientInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.tblPatients == null)
            {
                return NotFound();
            }

            var patientInfo = await _context.tblPatients.FindAsync(id);
            if (patientInfo == null)
            {
                return NotFound();
            }
            return View(patientInfo);
        }

        // POST: PatientInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [CustomAuthorizeAttribute("Admin", "Patient")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PatientId,PatientHistory,First_Name,Last_Name,EmailAddress,ContactNumber,HomeAddress")] PatientInfo patientInfo)
        {
            if (id != patientInfo.PatientId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patientInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatientInfoExists(patientInfo.PatientId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(patientInfo);
        }

        // GET: PatientInfoes/Delete/5
        [CustomAuthorizeAttribute("Admin", "Patient")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.tblPatients == null)
            {
                return NotFound();
            }

            var patientInfo = await _context.tblPatients
                .FirstOrDefaultAsync(m => m.PatientId == id);
            if (patientInfo == null)
            {
                return NotFound();
            }

            return View(patientInfo);
        }

        // POST: PatientInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [CustomAuthorizeAttribute("Admin","Patient")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.tblPatients == null)
            {
                return Problem("Entity set 'MyContext.PatientInfo'  is null.");
            }
            var patientInfo = await _context.tblPatients.FindAsync(id);
            if (patientInfo != null)
            {
                _context.tblPatients.Remove(patientInfo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatientInfoExists(int id)
        {
          return (_context.tblPatients?.Any(e => e.PatientId == id)).GetValueOrDefault();
        }

       




       // [HttpPost]
        public IActionResult BookApppointmentByPatient(int? id)
        {
           var role =HttpContext.Session.GetString("Role");

            if (role == null)
            {
                return RedirectToAction("RegisterPatient");
            }
            

            else
            {
                // code to retrieve the day of week
                ViewBag.dayofweek = HttpContext.Session.GetString("dayofweek");
                ViewBag.PTID = HttpContext.Session.GetString("Patient");
                ViewBag.Date = HttpContext.Session.GetString("dateofweek");
                ViewBag.Doctor = id;
                // create the model and set the AppointmentDay property
                var model = new Appointment();
                model.AppointmentDay = ViewBag.dayofweek;
                model.DocID = ViewBag.Doctor;
                model.AppointmentDate = ViewBag.Date;
                model.PatID = Int32.Parse(ViewBag.PTID);
                // model.PatID = ViewBag.PTID;
                return View(model);






               // ViewBag.dayofweek = HttpContext.Session.GetString("dayofweek");
              //   = dayofweek;
              //  ViewBag.PTID =  HttpContext.Session.GetString("Patient");
               // ViewBag.Doctor = id;
               // ViewBag.Pat = HttpContext.Session.GetString("PtID");
              //  return View();
            }
        }
    }
}
