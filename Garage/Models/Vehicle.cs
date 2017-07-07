using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage.Models
{
    public enum Color {
        Red, Green, Blue, Orange, Yellow, Pink, Black, Grey, White
    }

    public class Vehicle
    {
        public int Id { get; set; }

        [Display(Name = "Registration")]
        public string RegPlate { get; set; }
        public Color? Color { get; set; }
        public string Information { get; set; }
        public int OwnerId { get; set; }
        public int VehicleTypeId { get; set; }

        public virtual VehicleType VehicleType { get; set; }
        public virtual Owner Owner { get; set; }
    }
}