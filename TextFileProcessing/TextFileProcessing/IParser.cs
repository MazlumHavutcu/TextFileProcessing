using System.Collections.Generic;

namespace TextFileProcessing
{
    public interface IParser
    {
        /// <summary>
        /// This method parses the given string list.
        /// </summary>
        /// <param name="textLineList">The Line List</param>
        /// <returns>Parsed lines as list.</returns>
        List<string> Parse(List<string> textLineList);
    }
}
