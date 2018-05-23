using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TextProcessing.Interfaces;
using TextProcessing.Classes;
using System.Text.RegularExpressions;

namespace TextProcessing.Classes
{
    class Handling
    {
        public IList<Sentence> Sentences { get; set; } = new List<Sentence>();

        public IList<Sentence> TextParser(StreamReader textFile)
        {
            string inputLine = "";

            Punctuation punctuation = new Punctuation();

            //            Sentence sentence = new Sentence();

            IList<Sentence> sentencesList = new List<Sentence>();
            Regex rgx = new Regex("\\s+");

            while ((inputLine = textFile.ReadLine()) != null)
            {
                string[] inputArray = inputLine.Split(punctuation.PunctuationValue, StringSplitOptions.RemoveEmptyEntries);
                if (inputArray.Count() > 0)
                {
                    foreach (string s in inputArray)
                    {
                        string result = rgx.Replace(s, " ");
                        sentencesList.Add(new Sentence(result,false,7));
                    }
                }
            }
            return sentencesList;
        }
    }
}
