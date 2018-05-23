using System;
using TaxPark.Enums;

namespace TaxPark.Interfaces
{
    interface IVehicle
    {
        Guid Id { get; set; }
        string StateCarNumber { get; set; }
        AutoBrand AutoBrand { get; set; }
        string Name { get; set; }
        DateTime Produced { get; set; }
        double Price { get; set; }
        int MaximumSpeed { get; set; }
        FuelType FuelType { get; set; }
        double Сonsumption { get; set; }
        int Mileage { get; set; }
    }
}
