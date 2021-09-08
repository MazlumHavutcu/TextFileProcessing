using System.Collections.Generic;

namespace TextFileProcessing
{
    /// <summary>
    /// This class responsible for calculate word repetition.
    /// </summary>
    public class WordOccurrenceCalculator
    {
        public WordOccurrenceCalculator() { }

        /// <summary>
        /// This method finds out the word repetition.
        /// </summary>
        /// <param name="textList">The Text List</param>
        public Dictionary<string, int> Calculate(List<string> textList)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            foreach (string item in textList)
            {
                if (map.ContainsKey(item))
                {
                    int count = map[item] + 1;
                    map.Remove(item);
                    map.Add(item, count);
                }
                else
                {
                    map.Add(item, 1);
                }
            }

            return map;
        }
    }
}
