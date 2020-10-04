using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ao188116_MIS4200.Models
{
    public class Vet
    {
        [Display(Name = "Vet Name")]
        public int vetID { get; set; }
        [Display (Name = "Vet First Name")]
        [Required (ErrorMessage = "Vet first name is required")]
        [StringLength(25)]
        public string firstName { get; set; }
        [Display(Name = "Vet Last Name")]
        [Required(ErrorMessage = "Vet last name is required")]
        [StringLength(25)]
        public string lastName { get; set; }
        public ICollection<Appointment> Appointment { get; set; }

        public string vFullName { get
            {
                return firstName + " " + lastName;
            }
        }
    }
}