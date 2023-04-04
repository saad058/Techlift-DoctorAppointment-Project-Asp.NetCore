using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoctorAppointment.Data;
using DoctorAppointment.Models;
using DoctorAppointment.Models.Data.Repositories;
using DoctorAppointment.Services;
using DoctorAppointment.Data.Repositories;
using Microsoft.AspNetCore.Http;

namespace DoctorAppointment.Controllers
{
    public class DoctorInfoes1Controller : Controller
    {
        private readonly MyContext _context;
        private readonly IMailService _service;
        private readonly IUserLogin _user1;
        // private readonly IDepartmentRepository _repository;
        public DoctorInfoes1Controller(MyContext context, IMailService service, IUserLogin user1)
        {
            _context = context;
            _service = service;
            _user1 = user1;
            //  _repository = rep;   //Dependecy Injenction
        }

        // GET: DoctorInfoes1
        [CustomAuthorizeAttribute("Admin", "Doctor")]
        public async Task<IActionResult> Index()
        {

            // return View(await _context.tblDoctor.ToListAsync());
            //  string userEmail = User.Identity.Name; // get the email of the logged-in user
            string UserRole = HttpContext.Session.GetString("Role");
            ViewBag.Role = UserRole;
            if(UserRole =="Doctor") { 
            string userEmail = HttpContext.Session.GetString("UserEmail");
                var doctor = _context.tblDoctor.Where(p => p.EmailAddress == userEmail);
               // var doctor = await _context.tblDoctor.FirstOrDefaultAsync(d => d.EmailAddress == userEmail);
            //var qry = (from c in _context.tblDoctor
            //           join k in _context.tblDepartments
            //           on c.DepartmentId equals k.DepartmentId
            //           where c.EmailAddress == userEmail // filter by doctor's email
            //           select new DoctorInfo
            //           {
            //               First_Name = c.First_Name,
            //               Last_Name = c.Last_Name,
            //               DepartmentId = c.DepartmentId,
            //               EmailAddress = c.EmailAddress,
            //               ContactNumber = c.ContactNumber,
            //               HomeAddress = c.HomeAddress,
            //               IsAvailable = c.IsAvailable,
            //               DoctorFee = c.DoctorFee,
            //               Department = k
            //           }).ToList();
            return View(doctor);
            }

            else {

                //Linq= Language Integrated Query
                //var qry = (from c in _context.tblDoctor
                //           join k in _context.tblDepartments
                //           on c.DepartmentId equals k.DepartmentId
                //           select new DoctorInfo
                //           {
                //               First_Name = c.First_Name,
                //               Last_Name = c.Last_Name,
                //               DepartmentId = c.DepartmentId, //Mazeed field add ki ja skte ha
                //                                              //   AvailableDates=c.AvailableDates,
                //               EmailAddress = c.EmailAddress,
                //               ContactNumber = c.ContactNumber,
                //               HomeAddress = c.HomeAddress,
                //               IsAvailable = c.IsAvailable,
                //               DoctorFee = c.DoctorFee,
                //               Department = k

                //           }).ToList();
                //return View(qry);

                var qry = (from c in _context.tblDoctor
                           join k in _context.tblDepartments
                           on c.DepartmentId equals k.DepartmentId into department
                           from d in department.DefaultIfEmpty()
                           select new DoctorInfo
                           {
                               First_Name = c.First_Name,
                               Last_Name = c.Last_Name,
                               DepartmentId = c.DepartmentId,
                               EmailAddress = c.EmailAddress,
                               ContactNumber = c.ContactNumber,
                               HomeAddress = c.HomeAddress,
                               IsAvailable = c.IsAvailable,
                               DoctorFee = c.DoctorFee,
                               Department = d
                           }).ToList();
                return View(qry);



            }










        }

        // GET: DoctorInfoes1/Details/5
        [CustomAuthorizeAttribute("Admin", "Doctor")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctorInfo = await _context.tblDoctor
                .FirstOrDefaultAsync(m => m.DoctorId == id);
            if (doctorInfo == null)
            {
                return NotFound();
            }

            return View(doctorInfo);
        }

        [CustomAuthorizeAttribute( "Doctor")]
        // GET: DoctorInfoes1/Create
        public IActionResult Create()
        {
            ViewData["DepartmentId"] = new SelectList(_context.tblDepartments, "DepartmentId", "DepartmentName");
            // ViewData["Id"] = new SelectList(_context.tblWeekDays, "Id", "DayName");
            var doctorInfo = new DoctorInfo();
            var weekdays = new Weekdays();

            doctorInfo.Weekdays = weekdays;
            return View(doctorInfo);
        }

        // POST: DoctorInfoes1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DoctorId,IsAvailable,DepartmentId,DoctorFee,First_Name,Last_Name,EmailAddress,ContactNumber,HomeAddress")] DoctorInfo doctorInfo, Weekdays weekdays)
        {

            // Set the Weekdays property of the DoctorInfo object to the provided Weekdays object
            doctorInfo.Weekdays = weekdays;

            if (ModelState.IsValid)
            {
               // ViewData["DepartmentId"] = new SelectList(_context.tblDepartments, "DepartmentId", "DepartmentName", doctorInfo.DepartmentId);

                // Add the Weekdays object to the context and save changes
                _context.Add(weekdays);
                await _context.SaveChangesAsync();


                // Set the WeekdaysId property of the DoctorInfo object to the Weekdays object's primary key value
                doctorInfo.WeekdaysId = weekdays.WeekdaysId;


                //  ViewData["Id"] = new SelectList(_context.tblWeekDays, "Id", "DayName", );
                _context.Add(doctorInfo);
                await _context.SaveChangesAsync();

             
                    //if (Id != null)
                    //{
                    //    foreach (int id in Id)
                    //    {
                    //       Weekdays doctorWeekdays = new Weekdays
                    //        {
                    //           // DoctorId = doctorInfo.DoctorId,
                    //           // WeekdaysId = id
                    //        };
                    //        _context.Add(doctorWeekdays);
                    //    }
                    //    await _context.SaveChangesAsync();
                    //}






                    return RedirectToAction(nameof(Index));
            }


            ViewData["DepartmentId"] = new SelectList(_context.tblDepartments, "DepartmentId", "DepartmentName", doctorInfo.DepartmentId);
          //  ViewData["WeekdaysId"] = new SelectList(_context.tblWeekDays, "WeekdaysId", "DayName", Id);
           
            return View(doctorInfo);
        }

        // GET: DoctorInfoes1/Edit/5
        [CustomAuthorizeAttribute("Admin", "Doctor")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctorInfo = await _context.tblDoctor.FindAsync(id);
            if (doctorInfo == null)
            {
                return NotFound();
            }
            ViewData["DepartmentId"] = new SelectList(_context.tblDepartments, "DepartmentId", "DepartmentName", doctorInfo.DepartmentId);
            // var doct = new DoctorInfo();

            //var weekdays = new Weekdays();

            //doctorInfo.Weekdays = weekdays;
            var weekdays = await _context.tblWeekDays.FindAsync(doctorInfo.WeekdaysId);
            if (weekdays == null)
            {
                weekdays = new Weekdays();
            }

            // Map weekdays properties to DoctorInfo model
            doctorInfo.Weekdays = new Weekdays
            {
                Monday = weekdays.Monday,
                Tuesday = weekdays.Tuesday,
                Wednesday = weekdays.Wednesday,
                Thursday = weekdays.Thursday,
                Friday = weekdays.Friday,
                Saturday = weekdays.Saturday,
                Sunday = weekdays.Sunday
            };

            ViewData["DepartmentId"] = new SelectList(_context.tblDepartments, "DepartmentId", "DepartmentName", doctorInfo.DepartmentId);

            return View(doctorInfo);





           
        }

        // POST: DoctorInfoes1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [CustomAuthorizeAttribute("Admin", "Doctor")]
        [HttpPost]
      
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DoctorId,IsAvailable,DepartmentId,DoctorFee,First_Name,Last_Name,EmailAddress,ContactNumber,HomeAddress")] DoctorInfo doctorInfo, Weekdays weekdays)
        {
            // Set the Weekdays property of the DoctorInfo object to the provided Weekdays object
            doctorInfo.Weekdays = weekdays;
            if (id != doctorInfo.DoctorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(weekdays);
                   _context.SaveChanges();


                    // Set the WeekdaysId property of the DoctorInfo object to the Weekdays object's primary key value
                    doctorInfo.WeekdaysId = weekdays.WeekdaysId;

                    _context.Update(doctorInfo);
                    _context.SaveChanges();
                    //  ViewData["Id"] = new SelectList(_context.tblWeekDays, "Id", "DayName", );

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctorInfoExists(doctorInfo.DoctorId))
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

            ViewData["DepartmentId"] = new SelectList(_context.tblDepartments, "DepartmentId", "DepartmentName", doctorInfo.DepartmentId);

            return View(doctorInfo);
        }

        // GET: DoctorInfoes1/Delete/5
        [CustomAuthorizeAttribute("Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctorInfo = await _context.tblDoctor
                .FirstOrDefaultAsync(m => m.DoctorId == id);
            if (doctorInfo == null)
            {
                return NotFound();
            }

            return View(doctorInfo);
        }

        // POST: DoctorInfoes1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doctorInfo = await _context.tblDoctor.FindAsync(id);
            _context.tblDoctor.Remove(doctorInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoctorInfoExists(int id)
        {
            return _context.tblDoctor.Any(e => e.DoctorId == id);
        }


        [CustomAuthorizeAttribute("Admin")]
        public IActionResult RegisterDoctor()
        {
          //  ViewData["DepartmentId"] = new SelectList(_context.tblDepartments, "DepartmentId", "DepartmentName", doctorInfo.DepartmentId);

            return View();
        }
        [CustomAuthorizeAttribute("Admin")]
        [HttpPost]
        public IActionResult RegisterDoctor(DoctorInfo doct)
        {
           
            if (ModelState.IsValid)
            {
               // ViewData["DepartmentId"] = new SelectList(_context.tblDepartments, "DepartmentId", "DepartmentName", doctorInfo.DepartmentId);
                _context.Add(doct);
                _context.SaveChanges();

               
                // Generate a random password
                var password = GenerateRandomPassword();

                // Add user login info for the doctor
                var userLogin = new UserLogin
                {
                    LoginEmail = doct.EmailAddress,
                    Password = password,
                    UserRole = "Doctor"
                };
                // _context.tblUser.Add(userLogin);
                _context.Add(userLogin);
               _context.SaveChanges();
            
                // _user1.AddData(userLogin);





                // Send email to user email entered in DoctorInfo object
                var mailContent = new MailContent
                {
                    ToEmailAddress = doct.EmailAddress,
                    EmailSubject = "Registration Confirmation",
                    EmailBody = $"Thank you for registering as a doctor. Your login credentials are:\n\nEmail: {doct.EmailAddress}\nPassword: {password}"
                };

                _service.sendEmail(mailContent);

                return RedirectToAction("Create", "DoctorInfoes1");
            }
            return View(doct);
        }
        [CustomAuthorizeAttribute("Admin")]
        private string GenerateRandomPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var password = new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
            return password;
        }

        public ActionResult GetAvailableDoctors(string dayOfWeek, string dateOfWeek)
        {

           // var dateOfWeek = ViewBag.dateOfWeek;
            //var doctors = from d in _context.tblDoctor
            //              join w in _context.tblWeekDays on d.WeekdaysId equals w.WeekdaysId
            //              where d.IsAvailable && w.Thursday
            //              select d;

            //switch (dayOfWeek.ToLower())
            //{
            //    case "monday":
            //        doctors = doctors.Where(d => d.Weekdays.Monday);
            //        break;
            //    case "tuesday":
            //        doctors = doctors.Where(d => d.Weekdays.Tuesday);
            //        break;
            //    case "wednesday":
            //        doctors = doctors.Where(d => d.Weekdays.Wednesday);
            //        break;
            //    case "thursday":
            //        doctors = doctors.Where(d => d.Weekdays.Thursday);
            //        break;
            //    case "friday":
            //        doctors = doctors.Where(d => d.Weekdays.Friday);
            //        break;
            //    case "saturday":
            //        doctors = doctors.Where(d => d.Weekdays.Saturday);
            //        break;
            //    case "sunday":
            //        doctors = doctors.Where(d => d.Weekdays.Sunday);
            //        break;
            //    default:
            //       // doctors = Enumerable.Empty<DoctorInfo>();
            //        break;
            //}

            //return View(doctors.ToList());
            // ViewBag.Role = dayOfWeek;
            //dayOfWeek;
            HttpContext.Session.SetString("dayofweek", dayOfWeek);
            HttpContext.Session.SetString("dateofweek", dateOfWeek);
            var doctors = from d in _context.tblDoctor
                          join w in _context.tblWeekDays on d.WeekdaysId equals w.WeekdaysId
                          where d.IsAvailable &&
                                (dayOfWeek.ToLower() == "monday" && w.Monday ||
                                 dayOfWeek.ToLower() == "tuesday" && w.Tuesday ||
                                 dayOfWeek.ToLower() == "wednesday" && w.Wednesday ||
                                 dayOfWeek.ToLower() == "thursday" && w.Thursday ||
                                 dayOfWeek.ToLower() == "friday" && w.Friday ||
                                 dayOfWeek.ToLower() == "saturday" && w.Saturday ||
                                 dayOfWeek.ToLower() == "sunday" && w.Sunday)
                          select d;


            return View(doctors);
        }






    }




}
