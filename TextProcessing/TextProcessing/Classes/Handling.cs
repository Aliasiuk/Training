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
        public IList<Word> Words { get; set; } = new List<Word>();
        public IList<Sentence> Sentences { get; set; } = new List<Sentence>();

        public IList<Sentence> TextParser(StreamReader textFile)
        {
            string inputLine = "";
            string[] inputArray = new string[] { };

            Punctuation punctuation = new Punctuation();

            IList<Sentence> sentencesList = new List<Sentence>();
            IList<Word> wordsList = new List<Word>();

            Regex rgx1 = new Regex(@"\s+");
            Regex rgx2 = new Regex(@"\t+");

            while ((inputLine = textFile.ReadLine()) != null)
            {
                string result = rgx1.Replace(rgx2.Replace(inputLine, " "), " ");
                inputArray = result.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in inputArray)
                {
                    wordsList.Add(new Word(word, word.Length));
                }
            }
            if (wordsList.Count() > 0)
            {
                int varNumberOfWords = 0;
                StringBuilder sb = new StringBuilder();
                
                foreach (Word word in wordsList)
                {
                    sb.Append(word.WordValue).Append(" ");
                    varNumberOfWords++;
                    foreach (string punct in punctuation.PunctuationValue)
                    {
                        if (word.WordValue.Contains(punct))
                        {
                            string myResult = sb.ToString().Trim();
                            sentencesList.Add(new Sentence(myResult, myResult.Contains("?"), varNumberOfWords));
                            sb = new StringBuilder();
                            varNumberOfWords = 0;
                        }
                    }
                }
            }
            return sentencesList;
        }

        public IList<Sentence> GetSortedSentences()
        {
            return Sentences.OrderBy(x => x.NumberOfWords).ToList();
        }

        public IList<Sentence> GetWordsFromInterrogative()
        {
            return Sentences.Where(x => x.InterrogativeSentence==true).ToList();
        }
    }
}
