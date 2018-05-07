using System;
using TaxPark.Interfaces;
using TaxPark.Enums;

namespace TaxPark.Classes
{
    class Truck : VehicleBase, ITruck
    {
     public Truck(Guid id, AutoBrand autoBrand, string name, DateTime produced, double price,
                           int maximumSpeed, FuelType fuelType, double consumption, int mileage,
                           double cargo, int trunkLenght, int trunkHeight, int trunkWeight)
   : base(id, autoBrand, name, produced, price, maximumSpeed, fuelType, consumption, mileage)

        {
            Id = id;
            AutoBrand = autoBrand;
            Name = name;
            Produced = produced;
            Price = price;
            MaximumSpeed = maximumSpeed;
            FuelType = fuelType;
            Сonsumption = consumption;
            Mileage = mileage;
            Cargo = cargo;
            TrunkLenght = trunkLenght;
            TrunkHeight = trunkHeight;
            TrunkWeight = trunkWeight;
        }

        public double Cargo { get; set; }
        public int TrunkLenght { get; set; }
        public int TrunkHeight { get; set; }
        public int TrunkWeight { get; set; }
    }

}
