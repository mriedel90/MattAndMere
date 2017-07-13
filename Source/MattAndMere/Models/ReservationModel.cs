using MattAndMere.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MattAndMere.Models
{
    public class ReservationModel
    {
        public int Id { get; set; }

        [Display(Name = "Guest Name")]
        [Required(ErrorMessage="Please enter your name")]
        public string Name { get; set; }

        public string Email { get; set; }

        [Required(ErrorMessage = "Please indicate if you will be attending the wedding")]
        public bool? WillAttend { get; set; }

        [Required(ErrorMessage = "Please select a dinner preference")]
        public MealChoice? MealChoice { get; set;}

        [Required(ErrorMessage = "Please indicate if you will be taking the shuttle")]
        public bool? Shuttle { get; set; }
        
        [Display(Name="Hotel Selection")]
        [Required(ErrorMessage = "Please indicate the hotel you will take the shuttle to and from")]
        public string Hotel { get; set; }

        public string Message { get; set; }

        public DateTime DateCreated { get; set; }
    }
}