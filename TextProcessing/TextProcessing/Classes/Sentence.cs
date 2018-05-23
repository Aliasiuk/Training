using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessing.Classes
{
    class Sentence
    {
        public Sentence(string sentenceValue, bool interrogativeSentence, int numberOfWords)

        {
            SentenceValue = sentenceValue;
            InterrogativeSentence = interrogativeSentence;
            NumberOfWords = numberOfWords;
        }

        public string SentenceValue { get; }
        public bool InterrogativeSentence { get; }
        public int NumberOfWords { get;  }
    }
}
