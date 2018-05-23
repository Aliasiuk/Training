using System;
using TaxPark.Interfaces;
using TaxPark.Enums;

namespace TaxPark.Classes
{
    class VehicleBase : IVehicle
    {
        public VehicleBase(Guid id, string stateCarNumber, AutoBrand autoBrand, string name, DateTime produced, double price,
                           int maximumSpeed, FuelType fuelType, double consumption, int mileage)

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
        }

        public Guid Id { get; set; }
        public string StateCarNumber { get; set; }
        public AutoBrand AutoBrand { get; set; }
        public string Name { get; set; }
        public DateTime Produced { get; set; }
        public double Price { get; set; }
        public int MaximumSpeed { get; set; }
        public FuelType FuelType { get; set; }
        public double Сonsumption { get; set; }
        public int Mileage { get; set; }
    }
}
