using System.Collections.Generic;
using System.Linq;

namespace TextFileProcessing
{
    /// <summary>
    /// This class responsible for parsing by whitespace characters
    /// </summary>
    public class TextFileParser : IParser
    {

        public TextFileParser() { }

        /// <summary>
        /// This method splits list record by character.
        /// </summary>
        /// <param name="textLineList">The Line List</param>
        /// <returns>Parsed lines as list.</returns>
        public List<string> Parse(List<string> textLineList)
        {
            List<string> wordList = new List<string>();

            foreach (var line in textLineList)
            {
                string[] vs = line.Split(' ');
                wordList.AddRange(vs.Cast<string>().ToList());
            }
            return wordList;
        }
    }
}
