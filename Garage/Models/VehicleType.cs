using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Garage.Models
{
    public class VehicleType
    {
        public int Id { get; set; }

        [Display(Name = "Type")]
        public string Name { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
