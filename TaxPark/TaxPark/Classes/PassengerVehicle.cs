using System;
using TaxPark.Interfaces;
using TaxPark.Enums;

namespace TaxPark.Classes
{
    class PassengerVehicle : VehicleBase, IPassengerVehicle
    {
        public PassengerVehicle(Guid id, string stateCarNumber, AutoBrand autoBrand, string name, DateTime produced, double price,
                                int maximumSpeed, FuelType fuelType, double consumption, int mileage, int passengerNumber)
        :base(id, stateCarNumber, autoBrand, name, produced, price, maximumSpeed, fuelType, consumption, mileage)

        {
            Id = id;
            StateCarNumber = stateCarNumber;
            AutoBrand = autoBrand;
            Name = name;
            Produced = produced;
            Price = price;
            MaximumSpeed = maximumSpeed;
            FuelType = fuelType;
            Сonsumption = consumption;
            Mileage = mileage;
            PassengerNumber = passengerNumber;
        }

        public int PassengerNumber { get; set; }
    }
}
