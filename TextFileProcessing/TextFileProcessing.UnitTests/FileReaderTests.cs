using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Xunit;
using System.IO;

namespace TextFileProcessing.UnitTests
{
    public class FileReaderTests
    {

        [Fact]
        public void Should_Read_Succes()
        {
            //given
            FileReader fileReader = new FileReader(@"../../../Data/input.txt");

            //when
            List<string> lines = fileReader.ReadFile();

            //then
            Assert.AreEqual(18,lines.Count);
            CollectionAssert.Contains(lines, "1:15 Evheumque et Aruceum et Asineum");


        }

        [Fact]
        public void ReadFile_Should_Throw_FileNotFound()
        {
            //given
            FileReader fileReader = new FileReader(@"../../../Data/input1.txt");

            //when
            Xunit.Assert.Throws<FileNotFoundException>(() => fileReader.ReadFile());

        }
    }
}
