using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessing.Interfaces
{
    interface IWord : ISymbol
    {
        string WordValue { get; set; }
        int LengthWord { get; set; }
    }
}
