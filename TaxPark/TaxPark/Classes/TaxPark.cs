using System;
using System.Collections.Generic;
using System.Linq;
using TaxPark.Interfaces;
using TaxPark.Enums;

namespace TaxPark.Classes
{
    class TaxPark
    {
        public IList<IVehicle> Vehicles { get; set; } = new List<IVehicle>();
        
        public double GetTotalPrice()
        {
            return Vehicles.Sum(x => x.Price);
        }

        public IList<IVehicle> GetSortedVehicles()
        {
            return Vehicles.OrderBy(x => x.Сonsumption).ToList();
        }

        public IList<IVehicle> GetVehiclesBySpeed(int minSpeed, int maxSpeed)
        {
            return Vehicles.Where(x => x.MaximumSpeed > minSpeed && x.MaximumSpeed < maxSpeed).ToList();
        }
    }
}
