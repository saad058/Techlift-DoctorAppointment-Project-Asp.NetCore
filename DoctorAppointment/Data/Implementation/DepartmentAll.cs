using DoctorAppointment.Data.Repositories;
using DoctorAppointment.Models;
using DoctorAppointment.Models.Data.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace DoctorAppointment.Data.Implementation
{
    public class DepartmentAll : IDepartmentRepository
    {
        //Dependency Injection 
        private readonly MyContext _context; //Local variable
        public DepartmentAll(MyContext context) //dependency injenction ka variable database se arahe hai
        {
            _context= context;
        }

        public int AddData(Department obj)
        {
            _context.tblDepartments.Add(obj);
             return _context.SaveChanges(); 
        }

        public IEnumerable<Department> GetAllData()
        {
            return _context.tblDepartments.ToList();
        }

        public Department GetDatabyID(int id)
        {
            return _context.tblDepartments.Find(id);
        }

        public int RemoveData(int id) //View se arahe hai same as 
        {
            Department dpt = _context.tblDepartments.Find(id);
            _context.tblDepartments.Remove(dpt);
            return _context.SaveChanges();
        }

        public int UpdateData(Department obj, int Id)
        {
            _context.tblDepartments.Update(obj);
            return _context.SaveChanges();
        }
    }
}
