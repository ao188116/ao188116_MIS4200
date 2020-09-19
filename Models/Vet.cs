using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ao188116_MIS4200.Models
{
    public class Vet
    {
        public int vetID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
    }
}