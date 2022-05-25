using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace homeStay_MVC.Models
{
    public class PersonalDetails
    {
        [Key]
        public int PersonID { get; set; }


        [Required(ErrorMessage = "Enter the First Name")]
        public string FirstName { get; set; }

    }
}