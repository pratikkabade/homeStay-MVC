using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace homeStay_MVC.Models
{
    public class PDetails
    {
        [Key]
        public int PersonID { get; set; }


        [Required(ErrorMessage = "Enter the First Name")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Enter the First Name")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Enter the First Name")]
        public string DoB { get; set; }


        [Required(ErrorMessage = "Enter the First Name")]
        public string Gender { get; set; }


        [Required(ErrorMessage = "Enter the First Name")]
        public int ContactNumber { get; set; }


        [Required(ErrorMessage = "Enter the First Name")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Enter the First Name")]
        public string UserCategory { get; set; }

    }
}

