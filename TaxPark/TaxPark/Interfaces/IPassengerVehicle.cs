using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPark.Interfaces
{
    interface IPassengerVehicle : IVehicle
    {
        int PassengerNumber { get; set; }
    }
}
