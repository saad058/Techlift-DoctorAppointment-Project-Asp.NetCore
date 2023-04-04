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
    public class PatientVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PatientEmail { get; set; }
        public string Password { get; set; }

    }



}
