using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ao188116_MIS4200.Models
{
    public class Appointment
    {
        public int appointmentID { get; set; }
        public DateTime appointmentDate { get; set; }
        public string reasoning { get; set; }
        public int petID { get; set; }
        public virtual Pet Pet { get; set; }
        public int VetID { get; set; }
        public virtual Vet Vet { get; set; }

    }
}