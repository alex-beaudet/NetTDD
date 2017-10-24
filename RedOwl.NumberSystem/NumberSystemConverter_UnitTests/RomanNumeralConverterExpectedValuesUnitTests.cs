using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberSystemConverter;

namespace NumberSystemConverter_UnitTests
{
    [TestClass]
    public class RomanNumeralConverterExpectedValuesUnitTests
    {
        [TestMethod]
        public void Number_Equal_1_Expected_Result_I_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(1);

            Assert.AreEqual("I", result); 
        }

        [TestMethod]
        public void Number_Equal_3000_Expected_Result_MMM_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(3000);

            Assert.AreEqual("MMM", result); 
        }

        [TestMethod]
        public void Number_Equal_55_Expected_Result_LV_TestMethod()
        { 
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(55);

            Assert.AreEqual("LV", result);
        }

        [TestMethod]
        public void Number_Equal_100_Expected_Result_C_TestMethod()
        { 
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(100);

            Assert.AreEqual("C", result);
        }

        [TestMethod]
        public void Number_Equal_500_Expected_Result_D_TestMethod()
        { 
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(500);

            Assert.AreEqual("D", result);
        }

        [TestMethod]
        public void Number_Equal_599_Expected_Result_DLXXXXVIIII_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(599);

            Assert.AreEqual("DLXXXXVIIII", result);
        }

        [TestMethod]
        public void Number_Equal_2013_Expected_Result_MMXIII_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(2013);

            Assert.AreEqual("MMXIII", result);
        }
    }
}
