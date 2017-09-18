using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roman_Numerals;
using StartUp;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numerals_Test
{
    [TestClass]
    public class Program_Test
    {
        [TestMethod]
        public void MIsNotAnInt()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("M");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ElevenIsAnInt()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("11");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NegativeOneIsNotPositive()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("-1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZeroIsNotPositive()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneIsPositive()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoIsPositive()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("2");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FourThousandIsTooHigh()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooHigh("4000");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ThreeThousandNineHundredNinetyNineIsNotTooHigh()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooHigh("3999");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Inputting1RetrunsI()
        {
            var ExpectedType = "I";
            var utility = new Utility();

            var ActualType = utility.BuildRomanNumeral(1);

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void Inputting48ReturnsXLVIII()
        {
            var ExpectedType = "XLVIII";
            var utility = new Utility();

            var ActualType = utility.BuildRomanNumeral(48);

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void Inputting1682ReturnsMDCLXXXII()
        {
            var ExpectedType = "MDCLXXXII";
            var utility = new Utility();

            var ActualType = utility.BuildRomanNumeral(1682);

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void Inputting2824ReturnsMMDCCCXXIV()
        {
            var ExpectedType = "MMDCCCXXIV";
            var utility = new Utility();

            var ActualType = utility.BuildRomanNumeral(2824);

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void Inputting3999ReturnsMMMCMXCIX()
        {
            var ExpectedType = "MMMCMXCIX";
            var utility = new Utility();

            var ActualType = utility.BuildRomanNumeral(3999);

            Assert.AreEqual(ExpectedType, ActualType);
        }
    }
}
