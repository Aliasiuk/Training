using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessing.Classes
{
    class Word
    {
        public Word(string wordValue, int lengthWord)

        {
            WordValue = wordValue;
            LengthWord = lengthWord;
        }

        public string WordValue { get; set; }
        public int LengthWord { get; set; }
    }
}
