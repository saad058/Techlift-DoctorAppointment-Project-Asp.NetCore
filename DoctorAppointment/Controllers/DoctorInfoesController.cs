using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoctorAppointment.Models;
using DoctorAppointment.Data;

namespace DoctorAppointment.Controllers
{
    public class DoctorInfoesController : Controller
    {
        private readonly MyContext _context;

        public DoctorInfoesController(MyContext context)
        {
            _context = context;
        }

        // GET: DoctorInfoes
        public IActionResult Index()
        {
            //Linq= Language Integrated Query
            var qry = (from c in _context.tblDoctor
                      join k in _context.tblDepartments
                      on c.DepartmentId equals k.DepartmentId
                      
                      select new DoctorInfo 
                      {
                          First_Name=c.First_Name,
                          Last_Name=c.Last_Name,    
                          DepartmentId=c.DepartmentId, //Mazeed field add ki ja skte ha
                       //   AvailableDates=c.AvailableDates,
                          EmailAddress=c.EmailAddress,
                          ContactNumber=c.ContactNumber,    
                          HomeAddress=c.HomeAddress,
                          IsAvailable=c.IsAvailable,    
                          DoctorFee=c.DoctorFee,
                          Department=k

                      }).ToList();
            return View(qry);
            //var myContext = _context.DoctorInfo.Include(d => d.Department);
            //return View( myContext.ToListAsync());
        }

        // GET: DoctorInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.tblDoctor == null)
            {
                return NotFound();
            }

            var doctorInfo = await _context.tblDoctor
                .Include(d => d.Department)
                .FirstOrDefaultAsync(m => m.DoctorId == id);
            if (doctorInfo == null)
            {
                return NotFound();
            }

            return View(doctorInfo);
        }

        // GET: DoctorInfoes/Create
        public IActionResult Create()
        {
            ViewData["DepartmentId"] = new SelectList(_context.tblDepartments, "DepartmentId", "DepartmentName");
            return View();
        }

        // POST: DoctorInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DoctorId,IsAvailable,DepartmentId,DoctorFee,AvailableDates,First_Name,Last_Name,EmailAddress,ContactNumber,HomeAddress")] DoctorInfo doctorInfo)
        {
            ViewData["DepartmentId"] = new SelectList(_context.tblDepartments, "DepartmentId", "DepartmentName", doctorInfo.DepartmentId);
            _context.Add(doctorInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); 
        }

        // GET: DoctorInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.tblDoctor == null)
            {
                return NotFound();
            }

            var doctorInfo = await _context.tblDoctor.FindAsync(id);
            if (doctorInfo == null)
            {
                return NotFound();
            }
            ViewData["DepartmentId"] = new SelectList(_context.tblDepartments, "DepartmentId", "DepartmentName", doctorInfo.DepartmentId);
            return View(doctorInfo);
        }

        // POST: DoctorInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DoctorId,IsAvailable,DepartmentId,DoctorFee,AvailableDates,First_Name,Last_Name,EmailAddress,ContactNumber,HomeAddress")] DoctorInfo doctorInfo)
        {
            if (id != doctorInfo.DoctorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doctorInfo);
                    await _context.SaveChangesAsync();
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

        // GET: DoctorInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.tblDoctor == null)
            {
                return NotFound();
            }

            var doctorInfo = await _context.tblDoctor
                .Include(d => d.Department)
                .FirstOrDefaultAsync(m => m.DoctorId == id);
            if (doctorInfo == null)
            {
                return NotFound();
            }

            return View(doctorInfo);
        }

        // POST: DoctorInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.tblDoctor == null)
            {
                return Problem("Entity set 'MyContext.DoctorInfo'  is null.");
            }
            var doctorInfo = await _context.tblDoctor.FindAsync(id);
            if (doctorInfo != null)
            {
                _context.tblDoctor.Remove(doctorInfo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoctorInfoExists(int id)
        {
          return (_context.tblDoctor?.Any(e => e.DoctorId == id)).GetValueOrDefault();
        }
    }
}
