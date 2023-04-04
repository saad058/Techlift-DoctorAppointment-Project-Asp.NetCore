using DoctorAppointment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorAppointment.Data.Repositories.Implementation
{
    public class PatientAll : IPatientInfo
    {
        private readonly MyContext _context;
        //dependency Injection
        public PatientAll(MyContext context) // dependecy variable 
        {
            _context = context;
        }

        public int AddData(PatientInfo obj)
        {
            _context.tblPatients.Add(obj);
            return _context.SaveChanges();
        }

        public IEnumerable<PatientInfo> GetAllData()
        {
            return _context.tblPatients.ToList();
        }

        public PatientInfo GetDatabyID(int id)
        {
            return _context.tblPatients.Find(id);
        }

        public int RemoveData(int id)
        {
            PatientInfo patinetinf = _context.tblPatients.Find(id);

            _context.tblPatients.Remove(patinetinf);

            return _context.SaveChanges();
        }

        public int UpdateData(PatientInfo obj, int Id)
        {
            _context.tblPatients.Update(obj);
            return _context.SaveChanges();
        }
    }
}