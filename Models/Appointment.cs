using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ao188116_MIS4200.Models
{
    public class Appointment
    {
        public int appointmentID { get; set; }
        [Display (Name = "When was the Appointment?")]
        [DataType(DataType.Date)]
        public DateTime appointmentDate { get; set; }

        [Display(Name = "Reason for Appointment")]
        [StringLength(100)]
        [Required (ErrorMessage = "Must list reason for visit")]
        public string reasoning { get; set; }
        public int petID { get; set; }
        public virtual Pet Pet { get; set; }
        public int VetID { get; set; }
        public virtual Vet Vet { get; set; }

    }
}