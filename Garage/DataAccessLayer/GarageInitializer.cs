using Garage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Garage.DataAccessLayer
{
    public class GarageInitializer : DropCreateDatabaseAlways<GarageContext>
    {
        protected override void Seed(GarageContext context)
        {
            new List<VehicleType> {
                new VehicleType { Name = "Car" }, 
                new VehicleType { Name = "Truck" }, 
                new VehicleType { Name = "Bicycle" }
            }.ForEach(t => context.VehicleTypes.Add(t));
            context.SaveChanges();

            new List<Owner> {
                new Owner { FirstName = "Örjan", LastName = "Swensen" },
                new Owner { FirstName = "Stephen", LastName = "Angas" },
            }.ForEach(o => context.Owners.Add(o));
            context.SaveChanges();

            new List<Vehicle> {
                new Vehicle { RegPlate = "ABC123", VehicleTypeId = 1, OwnerId = 1, Color = Color.Black },
                new Vehicle { RegPlate = "BCD234", VehicleTypeId = 2, OwnerId = 2, Color = Color.Blue },
                new Vehicle {                      VehicleTypeId = 3, OwnerId = 1, Color = Color.Red },
                new Vehicle { RegPlate = "CDE345", VehicleTypeId = 1, OwnerId = 2, Information = "Nice car" },
                new Vehicle { RegPlate = "EFG456", VehicleTypeId = 2, OwnerId = 1 },
            }.ForEach(v => context.Vehicles.Add(v));
            context.SaveChanges();

        }
    }
}