using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace FIT5032_Assignment_Portfolio_V1._0.Models
{
    public class Report
    {
        [Required]
        public int ReportId { get; set; }
        
        [Required]
        [Display(Name = "Input Description")]
        public string Description { get; set; }
        
        [Required]
        [Display(Name = "Input correct Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public virtual List<Image> Images { get; set; }
    }
}