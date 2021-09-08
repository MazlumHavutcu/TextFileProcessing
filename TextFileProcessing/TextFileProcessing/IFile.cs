using System.Collections.Generic;

namespace TextFileProcessing
{
    public interface IFileReader
    {
        /// <summary>
        /// This method reads a file.
        /// </summary>
        /// <returns> File lines as list.</returns>
        List<string> ReadFile();

    }
}
