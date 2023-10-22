using FIT5032_Assignment_Portfolio_V1._0.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FIT5032_Assignment_Portfolio_V1._0.Context
{
    public class UltrasoundDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Image> Images { get; set; }

        public DbSet<Rating> Ratings { get; set; }

    }
}
    
