using Dental.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System;

namespace Dental.Infrastructure
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
            //Empty constructor.
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<DoctorModel> Doctors { get; set; }
        public DbSet<AppointmentModel> Appointments { get; set; }
        public DbSet<AdministrationModel> Administrations { get; set; }

       
    }
}