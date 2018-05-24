using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using TextProcessing.Classes;

namespace TextProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new AppSettingsReader();
            StreamReader textFile = null;
            StreamWriter newTextFile = null;

            try
            {
                var pathToFile = reader.GetValue("Key1", typeof(string));
                var pathToOutputFile = reader.GetValue("Key2", typeof(string));

                Console.WriteLine("Reading file :   " + pathToFile);
                textFile = new StreamReader(pathToFile.ToString());
                Console.WriteLine("Writing file :   " + pathToOutputFile);
                newTextFile = new StreamWriter(pathToOutputFile.ToString());

                Handling app = new Handling();

                IList<Sentence> sentenceList = app.TextParser(textFile);
                foreach (var sentenceVar in sentenceList)
                {
                    newTextFile.WriteLine(sentenceVar.SentenceValue);
                    //Console.WriteLine("{0} - {1} - {2}", sentenceVar.InterrogativeSentence, sentenceVar.NumberOfWords,
                    //    sentenceVar.SentenceValue);
                }

                newTextFile.WriteLine("####################################################################");

                app.Sentences = sentenceList;
                IList<Sentence> sentenceListSorted = app.GetSortedSentences();
                foreach (var sentenceVar in sentenceListSorted)
                    newTextFile.WriteLine("{0} # {1}", sentenceVar.NumberOfWords, sentenceVar.SentenceValue);

                newTextFile.WriteLine("####################################################################");

                IList<Word> wordListInterrogative = app.GetWordsFromInterrogative();
                IList<Word> resultList = wordListInterrogative.Distinct<Word>().ToList<Word>();

                foreach (Word wordVar in resultList)
                    newTextFile.WriteLine("{0} # {1}", wordVar.LengthWord, wordVar.WordValue);

                newTextFile.WriteLine("####################################################################");

                IList<Sentence> sentencesDelWordList = app.GetDeleteWords();
                foreach (Sentence sentenceVar in sentencesDelWordList)
                    newTextFile.WriteLine("{0} # {1}", sentenceVar.NumberOfWords, sentenceVar.SentenceValue);

                newTextFile.WriteLine("####################################################################");

                string sentenceReplaceWord = app.GetSentenceReplaceWord(5, "подстрока для замены");
                newTextFile.WriteLine("### {0}", sentenceReplaceWord);

                newTextFile.WriteLine("####################################################################");

                Console.ReadKey();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Missing key error: " + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("Could not read the file. Message = {0}", e.Message);
            }

            finally
            {
                if (textFile != null)
                {
                    textFile.Close();
                    newTextFile.Close();

                    Console.WriteLine("Done...");
                    Console.ReadKey();
                }
            }
        }
    }
}
