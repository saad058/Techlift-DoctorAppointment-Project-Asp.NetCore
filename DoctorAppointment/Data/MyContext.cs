using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DoctorAppointment.Models;
using DoctorAppointment.Models.MVVM;

namespace DoctorAppointment.Data
{
    public class MyContext : DbContext
    {
        
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }

        public DbSet<DoctorAppointment.Models.Department> tblDepartments { get; set; }

        public DbSet<DoctorAppointment.Models.PatientInfo> tblPatients { get; set; }

        public DbSet<DoctorAppointment.Models.DoctorInfo> tblDoctor { get; set; }

        public DbSet<DoctorAppointment.Models.UserLogin> tblUser { get; set; }

       public DbSet<DoctorAppointment.Models.Weekdays> tblWeekDays { get; set; }

       public DbSet<DoctorDepartmentVM> DoctorDepartments { get; set; }

        public DbSet<DoctorAppointment.Models.MVVM.PatientVM> PatientVM{ get; set; }

        public DbSet<DoctorAppointment.Models.Appointment> tblAppointment { get; set; }


        //public DbSet<DoctorDepartmentVM> DoctorDepartmentVMs { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.ApplyConfiguration(new DoctorDepartmentVMConfiguration());
        // }

        //   public DbSet<DoctorAppointment.Models.Appointment> tblAppointment { get; set; }

    }
}
