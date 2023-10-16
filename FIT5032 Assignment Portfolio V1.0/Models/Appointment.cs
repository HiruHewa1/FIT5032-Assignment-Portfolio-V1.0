using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FIT5032_Assignment_Portfolio_V1._0.Models
{
    public class Appointment
    {
        [Required]
        public int AppointmentId { get; set; }

        [Required]
        [Display(Name = "Input correct Date")]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }
        
        [Required]
        public virtual Patient Patient { get; set; }
        [Required]
        public virtual Report Report { get; set; }
    }
}