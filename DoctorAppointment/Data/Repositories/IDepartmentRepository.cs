using DoctorAppointment.Models;
using System.Collections.Generic;

namespace  DoctorAppointment.Models.Data.Repositories
{
    public interface IDepartmentRepository
    {
        public int AddData(Department obj);
        int RemoveData(int id);
        Department GetDatabyID(int id);
        //IEnumerable is equal to List
        IEnumerable<Department> GetAllData();
        int UpdateData(Department obj,int Id);
    }
}
