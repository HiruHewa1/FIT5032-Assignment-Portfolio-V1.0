using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FIT5032_Assignment_Portfolio_V1._0.Models
{
    public class Feedback
    {
        [Key]
        public string UserID { get; set; }
        public string RatingDesc { get; set; }
        public int RatingValue { get; set; }

    }

}