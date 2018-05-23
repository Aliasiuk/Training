using System;
using System.Collections.Generic;
using TaxPark.Interfaces;
using TaxPark.Classes;
using TaxPark.Enums;

namespace TaxPark
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IVehicle> taxi = new List<IVehicle>
            {
               new PassengerVehicle(Guid.NewGuid(), "3334 AM-4", AutoBrand.Audi, "A6", new DateTime(2008,10,30), 2039498, 200, FuelType.AI95, 10.5f, 157000, 4),
               new Truck(Guid.NewGuid(), "6783 EX-4", AutoBrand.Volkswagen, "T9", new DateTime(2000,01,30), 67382, 130, FuelType.Diesel, 12f, 350000, 5, 4, 2, 2),
               new PassengerVehicle(Guid.NewGuid(), "7334 AM-4", AutoBrand.Audi, "A4", new DateTime(2005,10,30), 3039498, 170, FuelType.AI92, 8.5f, 307000, 4),
               new PassengerVehicle(Guid.NewGuid(), "2744 AM-4", AutoBrand.Mersedes, "Sprinter", new DateTime(2015,11,30), 56339498, 140, FuelType.Diesel, 9.5f, 57000, 14),
               new Truck(Guid.NewGuid(), "7983 EX-4", AutoBrand.Mersedes, "Sprinter", new DateTime(2003,01,30), 167382, 137, FuelType.Diesel, 12f, 170000, 5, 4, 2, 2),
               new Truck(Guid.NewGuid(), "3383 EX-4", AutoBrand.Volkswagen, "T9", new DateTime(2012,01,30), 567382, 125, FuelType.Diesel, 10f, 51030, 5, 4, 2, 2)
            };

            TaxiPark app = new TaxiPark();
            app.Vehicles = taxi;

            double totalPrice = app.GetTotalPrice();
            Console.WriteLine("Taxipark total cost : {0}", totalPrice.ToString());
            Console.WriteLine();

            Console.WriteLine("Sort by fuel consumption:");
            IList<IVehicle> sortedVehicles = app.GetSortedVehicles();
            foreach (var taxiCar in sortedVehicles)
                Console.WriteLine("{0} - {1} ; {2} ; {3} ; {4}; {5}", 
                                  taxiCar.Сonsumption, taxiCar.StateCarNumber, taxiCar.AutoBrand, taxiCar.Name, taxiCar.FuelType.ToString(), taxiCar.Produced.ToString());

            Console.WriteLine();

            Console.WriteLine("Search by speed range.");
            int minSpeed, maxSpeed;
            do {
                Console.Write("Enter the minimum speed: ");
                minSpeed=Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the maximum speed: ");
                maxSpeed=Convert.ToInt32(Console.ReadLine());
            } while (minSpeed > maxSpeed);
            IList<IVehicle> findVehicleBySpeed = app.GetVehiclesBySpeed(minSpeed, maxSpeed);
            if (findVehicleBySpeed.Count > 0)
            {
                Console.WriteLine("Result:");
                foreach(var taxiCar in findVehicleBySpeed)
                    Console.WriteLine("{0} - {1} ; {2} ; {3}", taxiCar.MaximumSpeed, taxiCar.StateCarNumber, taxiCar.AutoBrand, taxiCar.Name);
            }
            else
            {
                Console.WriteLine("No cars found with specified parameters");
            }

            Console.ReadKey();
            
        }
    }
}
