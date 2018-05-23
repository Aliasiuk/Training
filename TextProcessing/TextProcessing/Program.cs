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
            try
            {
                var pathToFile = reader.GetValue("Key1", typeof(string));
                var pathToOutputFile = reader.GetValue("Key2", typeof(string));

                Console.WriteLine("Path :   " + pathToFile);
                textFile = new StreamReader(pathToFile.ToString());
                Handling app = new Handling();
                IList<Sentence> sentenceList = app.TextParser(textFile);
                foreach (var sentenceVar in sentenceList)
                    Console.WriteLine("{0}", sentenceVar.SentenceValue);

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
                }
            }
        }
    }
}
