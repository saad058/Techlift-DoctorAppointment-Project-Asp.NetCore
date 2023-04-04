using DoctorAppointment.Data.Repositories;
using DoctorAppointment.Models;

using DoctorAppointment.Models.Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DoctorAppointment.Controllers
{

    //[Authorize]
    // Yaha Controller mai repository calls hongi...
    public class DepartmentController : Controller
    {
        
        List<DoctorInfo> lst = new  List<DoctorInfo>(); 
        private readonly IDepartmentRepository _repository;
        public DepartmentController(IDepartmentRepository rep)
        {
            _repository= rep;   //Dependecy Injenction
        }
        public IActionResult GetAllDeparts()
        {
            //ViewBag.Role = "Admin";
            //TempData["Role"] = ViewBag.Role;
            //HttpContext.Session.SetString("Role", "Admin");
            return View(_repository.GetAllData());
        }
        [CustomAuthorizeAttribute("Admin")]
        public IActionResult DeleteByID(int id)
        {
           
            return View(_repository.RemoveData(id));
        }
       
        public IActionResult Edit(int id)
        {

            return View(_repository.RemoveData(id));
        }
        [CustomAuthorizeAttribute("Admin")]
        public IActionResult AddNew()
        {
           // ViewBag.Role = "Admin";
           // TempData["Role"] = ViewBag.Role;
           // HttpContext.Session.SetString("Role", "Admin");
            return View();
        }
        [HttpPost]
        public IActionResult AddNew(Department obj,string FirstName,string LastName) 
        {
            DoctorInfo inf = new DoctorInfo();
            
            inf.First_Name=FirstName;
            inf.Last_Name=LastName;
            lst.Add(inf);
            obj.Doctors = lst;

            //DayOfWeek day= DateTime.Today.DayOfWeek;
            //int difference = day - DayOfWeek.Monday;
            //DateTime startingdateofweek=DateTime.Now.AddDays(-difference).Date;     

            _repository.AddData(obj);   
            return View(obj);   
        }
      


        //public ActionResult Delete(int isbn)
        //{
        //    var res = dbLib.Libraries.Where(x => x.ISBN == isbn).First();
        //    dbLib.Libraries.Remove(res);
        //    dbLib.SaveChanges();
        //    var list = dbLib.Libraries.ToList();
        //    return View("LibraryList", list);
        //}


    }
}
