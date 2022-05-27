using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace homeStay_MVC.Models
{
    public class Info
    {
        [Key]
        public int PersonID { get; set; }


        [Required(ErrorMessage = "Please enter First Name")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Please enter Last Name")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Please enter DoB")]
        public string DoB { get; set; }


        [Required(ErrorMessage = "Please enter Gender")]
        public string Gender { get; set; }


        [Required(ErrorMessage = "Please enter Contact Number")]
        public int ContactNumber { get; set; }


        [Required(ErrorMessage = "Please enter Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please enter link User Category")]
        public string UserCategory { get; set; }
    }
}