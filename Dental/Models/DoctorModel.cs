using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dental.Models
{
    public class DoctorModel
    {   
        public int ID { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name ="Dentist's Name" )]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [MyBirthDateValidation(ErrorMessage = "Date of Birth cannot be from the future!")]
        public DateTime BirthDate { get; set; }

        [Required]
        public Enums.Degree Degree { get; set; }

        [Required]
        public Enums.DentalOffice DentalOffice { get; set; }
        public Enums.Specialty Specialty { get; set; }

        [Display(Name="New Appointments Disabled")]
        public Boolean DisableNewAppointments { get; set; }

        public virtual List<AppointmentModel> Appointments { get; set;}
    }
}
