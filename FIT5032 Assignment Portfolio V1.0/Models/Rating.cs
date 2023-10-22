using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FIT5032_Assignment_Portfolio_V1._0.Models
{
    public class Rating
    {
        [Key]
        public string UserId { get; set; }
        public string Description { get; set; }
        public int Val { get; set; }
    }
}