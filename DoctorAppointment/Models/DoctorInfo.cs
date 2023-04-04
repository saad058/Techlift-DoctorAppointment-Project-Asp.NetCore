using DoctorAppointment.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorAppointment.Models
{
    public class DoctorInfo:BaseClass
    {
        [Key]
        public int DoctorId { get; set; } // Scalar property
        public bool IsAvailable { get; set; }
        public int? DepartmentId { get; set; }
        /// <summary>
        /// navigation property 
        /// Relationship 
        /// </summary>

        public int DoctorFee { get; set; }




        //public DateTime AvailableDates { get; set; }
        [NotMapped]
        public Department Department { get;  set; }//Relation is called Navigation Property



        //public int? WeekdaysId { get; set; }
        //  public IEnumerable <Weekdays> Weekdays { get; set; }

        public int? WeekdaysId { get; set; }
        [NotMapped]
        public Weekdays Weekdays { get; set; }


    }
}


