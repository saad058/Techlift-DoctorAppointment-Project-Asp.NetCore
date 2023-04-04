using DoctorAppointment.Models;
using System.Collections.Generic;

namespace DoctorAppointment.Data.Repositories
{
    public interface IAppointment
    {
        public int AddData(Appointment obj);
        int RemoveData(int id);
        Appointment GetDatabyID(int id);
        //IEnumerable is equal to List
        IEnumerable<Appointment> GetAllData();
        int UpdateData(Appointment obj, int Id);
    }
}
