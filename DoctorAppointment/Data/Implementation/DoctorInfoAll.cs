using DoctorAppointment.Data.Repositories;
using DoctorAppointment.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DoctorAppointment.Data.Implementation
{
    public class DoctorInfoAll:IDoctorInfo,IDisposable
    {
        //Dependency Injection 
        private readonly MyContext _context; //Local variable
        public DoctorInfoAll(MyContext context) //dependency ka variable database se arahe hai
        {
            _context = context;
        }

        public int AddData(DoctorInfo obj)
        {
            _context.Add(obj);
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IEnumerable<DoctorInfo> GetAllData()
        {
            return _context.tblDoctor.ToList();
        }

        public DoctorInfo GetDatabyID(int id)
        {
            return _context.tblDoctor.Find(id);
        }

        public int RemoveData(int id) //View se arahe hai same as 
        {
            DoctorInfo doc = _context.tblDoctor.Find(id);
            _context.tblDoctor.Remove(doc);
            return _context.SaveChanges();
        }

        public int UpdateData(DoctorInfo obj, int Id)
        {
            _context.tblDoctor.Update(obj);
            return _context.SaveChanges();
        }
    }
}
