using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPark.Interfaces
{
    interface ITruck : IVehicle
    {
        double Cargo { get; set; }
        int TrunkLenght { get; set; }
        int TrunkHeight { get; set; }
        int TrunkWeight { get; set; }
    }
}
