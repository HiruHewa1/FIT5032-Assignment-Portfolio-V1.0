using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FIT5032_Assignment_Portfolio_V1._0.Models
{
    public class Patient
    {
        [Required]
        
        public int PatientId { get; set; }

        [Required]
        [StringLength(50,MinimumLength =1)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string LastName { get; set; }
        
        [Required]
        [EmailAddress]
        [Display(Name ="Email")]
        public string Email { get; set; }
        
        [Required]
        [Display(Name = "Input correct Date")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

      
        public string userid { get; set; }

        public virtual List<Appointment> Appointments { get; set; }
    }
}