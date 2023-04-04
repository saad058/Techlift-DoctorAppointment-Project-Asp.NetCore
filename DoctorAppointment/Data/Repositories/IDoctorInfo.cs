using DoctorAppointment.Models;
using System.Collections.Generic;

namespace DoctorAppointment.Data.Repositories
{
    public interface IDoctorInfo
    {
        public int AddData(DoctorInfo obj);
        int RemoveData(int id);
        DoctorInfo GetDatabyID(int id);
        //IEnumerable is equal to List
        IEnumerable<DoctorInfo> GetAllData();
        int UpdateData(DoctorInfo obj, int Id);
    }
}
