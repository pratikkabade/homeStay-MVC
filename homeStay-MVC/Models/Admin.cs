using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace homeStay_MVC.Models
{
    public class Admin
    {
        [Key]
        public int RoomID { get; set; }


        [Required(ErrorMessage = "Please enter link for Picture1")]
        public string picOne { get; set; }


        [Required(ErrorMessage = "Please enter link for Picture2")]
        public string picTwo { get; set; }


        [Required(ErrorMessage = "Please enter link for Picture3")]
        public string picThree { get; set; }


        [Required(ErrorMessage = "Please enter name of Room")]
        public string RoomName { get; set; }


        [Required(ErrorMessage = "Please enter number of Stars")]
        public int Stars { get; set; }


        [Required(ErrorMessage = "Please enter Address")]
        public string Address { get; set; }


        [Required(ErrorMessage = "Please enter link  of rooms Official Website")]
        public string Website { get; set; }


        [Required(ErrorMessage = "Please enter link for Rating")]
        public int Rating { get; set; }


        [Required(ErrorMessage = "Please enter Price")]
        public int Price { get; set; }
    }
}