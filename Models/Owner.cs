using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ao188116_MIS4200.Models
{
    public class Owner
    {
        public int ownerID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Owner first name is required")]
        [StringLength(25)]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Owner last name is required")]
        [StringLength(25)]
        public string lastName { get; set; }

        [Display(Name = "Mobile Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$", ErrorMessage = "Phone Numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
            
        public string phone { get; set; }

        [Display (Name = "Steet Address")]
        [Required(ErrorMessage = "Street Address is required")]
        [StringLength(100)]
        public string address { get; set; }
        
        [Display (Name = "Email")]
        [Required(ErrorMessage = "Valid Email Address is required")]
        [DataType(DataType.EmailAddress)]
        public string emailAddress { get; set; }

        public string fullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }
        
      
        public ICollection<Pet> Pet { get; set; }

    }
}