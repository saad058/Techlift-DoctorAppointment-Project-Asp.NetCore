using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace DoctorAppointment.Models.MVVM
{
   [NotMapped]
  // [keyless]
    public class DoctorDepartmentVM
    {
        public string DepartmentName { get; set; }
        public string DoctorName { get; set; }
        public string DoctorEmail { get; set; }

    }


    //public class DoctorDepartmentVMConfiguration : IEntityTypeConfiguration<DoctorDepartmentVM>
    //{
    //    public void Configure(EntityTypeBuilder<DoctorDepartmentVM> builder)
    //    {
    //        builder.HasNoKey();
    //        builder.ToView("DoctorDepartmentVM");
    //    }
    //}

}
