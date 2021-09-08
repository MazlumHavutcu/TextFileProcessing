using System.Collections.Generic;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TextFileProcessing.UnitTests
{
    public class WordOccurrenceCalculatorTests
    {

        [Fact]
        public void Calculate_Should_Return_Succes_Result()
        {
            //given
            WordOccurrenceCalculator calculator = new WordOccurrenceCalculator();
            List<string> given = new List<string> { "mazlum", "deneme", ".Net,", "Tst.", "deneme" };
            //when
            Dictionary<string, int> result = calculator.Calculate(given);
            //then
            Assert.AreEqual(result["deneme"],2);
            Assert.AreEqual(result["mazlum"], 1);

        }

        [Fact]
        public void Calculate_Should_Empty_List()
        {
            //given
            WordOccurrenceCalculator calculator = new WordOccurrenceCalculator();
            List<string> given = new List<string>();
            //when
            Dictionary<string, int> result = calculator.Calculate(given);
            //then
            Assert.AreEqual(result.Count, 0);

        }

    }
}
