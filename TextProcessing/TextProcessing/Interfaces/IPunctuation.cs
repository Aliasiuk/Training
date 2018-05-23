using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessing.Interfaces
{
    interface IPunctuation : IWord
    {
        string[] PunctuationValue { get; }
    }
}
