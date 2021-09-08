using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TextFileProcessing.UnitTests
{
    public class TextFileParserTests
    {
        [Fact]
        public void Parse_Should_Return_Parsed_Data()
        {
            //given
            TextFileParser parser = new TextFileParser();
            List<string> given = new List<string> { "mazlum deneme",".Net, Tst. deneme" };
            List<string> expected = new List<string> { "mazlum", "deneme", ".Net,", "Tst.","deneme" };
            //when
            List<string> list = parser.Parse(given);
            //then
            CollectionAssert.AreEqual(expected, list);
            CollectionAssert.AreNotEqual(expected, given);
            Assert.AreEqual(list.Count, 5);
        }

        [Fact]
        public void Parse_Should_Parse_Empty_List()
        {
            //given
            TextFileParser parser = new TextFileParser();
            List<string> given = new List<string>();
            //when
            List<string> list = parser.Parse(given);
            //then
            CollectionAssert.DoesNotContain(list, "");
            Assert.AreEqual(list.Count, 0);
        }

        [Fact]
        public void Parse_Should_Return_Same_Value()
        {
            //given
            TextFileParser parser = new TextFileParser();
            List<string> given = new List<string> { "dddddddddddddd" };
            //when
            List<string> list = parser.Parse(given);
            //then
            CollectionAssert.AreEqual(given, list);
        }
    }
}
