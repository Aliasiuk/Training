using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessing.Interfaces
{
    interface ISentence : ISymbol, IWord, IPunctuation
    {
        string SentenceValue { get; }
        bool InterrogativeSentence { get; }
        int NumberOfWords { get; }
    }
}
