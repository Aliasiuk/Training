using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessing.Classes
{
    class Word
    {
        string WordValue { get; }
        int LengthWord { get { return WordValue.Length; } }
    }
}
