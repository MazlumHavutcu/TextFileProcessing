using System;
using System.Collections.Generic;
using System.Linq;

namespace TextFileProcessing
{
    /// <summary>
    /// This program written for client who need to check file contents.
    /// It extract and count all worlds in the file.
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                string appName = "-- Parser --";
                Console.WriteLine("{0}", appName);

                Console.WriteLine("Please type file directory.");
                string filePath = Console.ReadLine();

                IFileReader fileReader = new FileReader(filePath);
                List<string> lineList = fileReader.ReadFile();

                IParser parser = new TextFileParser();
                List<string> list = parser.Parse(lineList);

                WordOccurrenceCalculator wordOccurrenceCalculator = new WordOccurrenceCalculator();

                Dictionary<string, int> wordOccurrenceDictionary = wordOccurrenceCalculator.Calculate(list);
                Dictionary<string, int> sortedDictionary = DictionarySort(wordOccurrenceDictionary);

                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("word  occurence");
                Console.WriteLine(string.Join("\n", sortedDictionary.Select(kvp => $"{kvp.Key}\t{kvp.Value}")));
                Console.WriteLine("---------------------------------------------------------");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Press any key to exit");
            _ = Console.ReadKey();

        }

        private static Dictionary<string, int> DictionarySort(Dictionary<string, int> dictionary)
        {
            return (from pair in dictionary
                    orderby pair.Value descending
                    select pair).ToDictionary(pair => pair.Key, pair => pair.Value);
        }
    }
}
