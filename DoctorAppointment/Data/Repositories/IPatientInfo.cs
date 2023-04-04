using DoctorAppointment.Models;
using System.Collections.Generic;

namespace DoctorAppointment.Data.Repositories
{
    public interface IPatientInfo
    {
        public int AddData(PatientInfo obj);
        int RemoveData(int id);
        PatientInfo GetDatabyID(int id);
        //IEnumerable is equal to List
        IEnumerable<PatientInfo> GetAllData();
        int UpdateData(PatientInfo obj, int Id);
    }
}
