
using DoctorAppointment.Data.Repositories;
using DoctorAppointment.Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace DoctorAppointment.Data.Implementation
{
    // public class UserLoginAll:IUserLogin,IDisposable
    public class UserLoginAll : IUserLogin
    {
        //Dependency Injection 
        private readonly MyContext _context; //Local variable
        public UserLoginAll(MyContext context) //dependency ka variable database se arahe hai
        {
            _context = context;
        }

        //public Task<int> AddData(UserLogin obj)
        //{
        //    _context.tblUser.Add(obj);
        ////   int res = _context.SaveChanges();
        //    return _context.SaveChangesAsync();
        //}



        public IEnumerable<UserLogin> GetAllData()
        {
            return _context.tblUser.ToList();
        }

        public UserLogin GetDatabyID(int id)
        {
            return _context.tblUser.Find(id);
        }

        public int RemoveData(int id) //View se arahe hai same as 
        {
            UserLogin uss = _context.tblUser.Find(id);
            _context.tblUser.Remove(uss);
            return _context.SaveChanges();
        }

        public int UpdateData(UserLogin obj, int Id)
        {
            _context.tblUser.Update(obj);
            return _context.SaveChanges();
        }

        //public async Task SaveChangesAsync()
        //{
        //    await _context.SaveChangesAsync();
        //}

        public void Dispose()
        {
            _context.Dispose();
        }

        public int AddData(UserLogin obj)
        {
            _context.tblUser.Add(obj);
           // int res = _context.SaveChanges();
         return _context.SaveChanges();
        }
    }
}
