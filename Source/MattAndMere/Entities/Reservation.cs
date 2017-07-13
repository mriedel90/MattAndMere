using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MattAndMere.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool WillAttend { get; set; }
        public MealChoice MealChoice { get; set; }
        public bool Shuttle { get; set; }
        public string Hotel { get; set; }
        public string Message { get; set; }
        public DateTime DateCreated { get; set; }
    }

    public enum MealChoice
    {
        None = 0,
        Salmon = 1,
        Pork = 2,
        Ravioli = 3
    }
}