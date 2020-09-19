using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ao188116_MIS4200.Models
{
    public class Pet
    {
        [Key]
        public int petID { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string animalType { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
        public int OwnerID { get; set; }
        public virtual Owner Owner { get; set; }

    }
}