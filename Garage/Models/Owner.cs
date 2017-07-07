using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Garage.Models
{
    public class Owner
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return string.Join(
                    " ",
                    new[] { FirstName, LastName }.Where(
                        s => !string.IsNullOrWhiteSpace(s)
                    ));
            }
        }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
