using DoctorAppointment.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoctorAppointment.Data.Repositories
{
    public interface IUserLogin
    {
        // public Task<int> AddData(UserLogin obj);
        public int AddData(UserLogin obj);
        int RemoveData(int id);
        UserLogin GetDatabyID(int id);
        //IEnumerable is equal to List
        IEnumerable<UserLogin> GetAllData();
        int UpdateData(UserLogin obj, int Id);

    

    }
}
