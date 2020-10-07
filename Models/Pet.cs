using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ao188116_MIS4200.Models
{
    public class Pet
    {
        [Key]

        public int petID { get; set; }

        [Display (Name = "Pet Name")]
        [Required (ErrorMessage = "Pet Name is required")]
        [StringLength(25)]
        public string name { get; set; }

        [Display (Name = "Age")]
        [Required (ErrorMessage = "Age of pet is required")]
        public int age { get; set; }

        [Display (Name = "Type of Animal")]
        [Required (ErrorMessage = "Type of animal required")]
        [StringLength(20)]
        public string animalType { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
        
        public int OwnerID { get; set;}
        public virtual Owner Owner { get; set; }

    }
}