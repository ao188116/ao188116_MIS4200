using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ao188116_MIS4200.Models
{
    public class Owner
    {
        public int ownerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string emailAddress { get; set; }
        public ICollection<Pet> Pet { get; set; }

    }
}