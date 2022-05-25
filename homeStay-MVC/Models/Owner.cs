using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace homeStay_MVC.Models
{
    public class Owner
    {
        [Key]
        public int OwnerID { get; set; }


        [Required(ErrorMessage = "Enter the Owner Name")]
        public string OwnerName { get; set; }


        [Required(ErrorMessage = "Contact No is Required")]
        public string ContactNo { get; set; }
    }
}