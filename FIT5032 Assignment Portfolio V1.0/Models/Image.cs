using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FIT5032_Assignment_Portfolio_V1._0.Models
{
    public class Image
    {
        [Required]
        [Range(1,double.PositiveInfinity)]
        public int ImageId { get; set; }
        public byte[] UltrasoundImage { get; set; }

        public string Path { get; set; }
        public virtual Report Report { get; set; }
    }
}