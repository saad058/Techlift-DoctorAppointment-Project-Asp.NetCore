
using DoctorAppointment.Models;
using DoctorAppointment.Data.Repositories;
using System.Collections.Generic;
using System.Linq;


namespace DoctorAppointment.Data.Implementation
{
    public class AppointmentAll : IAppointment
    {
        //Dependency Injection 
        private readonly MyContext _context; //Local variable
        public AppointmentAll(MyContext context) //dependency ka variable database se arahe hai
        {
            _context = context;
        }

        public int AddData(Appointment obj)
        {
            _context.tblAppointment.Add(obj);
            return _context.SaveChanges();
        }

        public IEnumerable<Appointment> GetAllData()
        {
            return _context.tblAppointment.ToList();
        }

        public Appointment GetDatabyID(int id)
        {
            throw new System.NotImplementedException();
        }

        public int RemoveData(int id)
        {
            throw new System.NotImplementedException();
        }

        public int UpdateData(Appointment obj, int Id)
        {
            throw new System.NotImplementedException();
        }
    }

}