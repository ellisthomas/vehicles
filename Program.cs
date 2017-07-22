using System;
using System.Linq;
using System.Collections.Generic;
using vechiles.Vehicles;
using vehicles.Vehicles;
using vechiles;

namespace vehicles
{
    class Program
    {
        static void Main()
        {

            var airVehicles = new List<IAirVehice> {
                new Cessna(), new Helicopter()
            };

            foreach (var vehicle in airVehicles)
            {
                vehicle.Fly();
                vehicle.Land();
                Console.WriteLine();

            }
           
           var roadVechiles = new List<IDrivableVehicle> {
               new Delorean(), new Motorcycle()
           };

           foreach (var vehicle in roadVechiles)
           {
               vehicle.Drive();
               vehicle.Stop();
               Console.WriteLine();
           }

           var waterVehciles = new List<IWaterVehicle> {
               new JetSki(), new RowBeat()
           };

           foreach (var vehicle in waterVehciles)
           {
               vehicle.Start();
               
               var driveableVehicle = vehicle as IDrivableVehicle;
               if(driveableVehicle != null) {
                   driveableVehicle.Drive();
                   driveableVehicle.Stop();
               }
           }


        // Build a collection of all vehicles that operate on water
        
        // With a single `foreach`, have each water vehicle Drive()

    
        }
    }
}
