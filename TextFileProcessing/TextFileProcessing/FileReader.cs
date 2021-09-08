using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TextFileProcessing
{
    /// <summary>
    /// This class responsible for read file as a stream
    /// </summary>
    public class FileReader : IFileReader
    {
        private string FilePath;

        public FileReader(string FilePath) { this.FilePath = FilePath; }

        /// <summary>
        /// This method reads all line as stream
        /// </summary>
        /// <returns>File lines as list</returns>
        public List<string> ReadFile()
        {
            List<string> fileLineList = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(FilePath, Encoding.GetEncoding("windows-1250")))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        fileLineList.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                throw e;
            }
            return fileLineList;
        }
    }
}
