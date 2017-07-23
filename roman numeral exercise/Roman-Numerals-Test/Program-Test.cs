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
        public void IdentifiesInputsOfZero()
        {
            bool ExpectedType = true;
            var testVer = new Verification();

            bool ActualType = testVer.Zero(0);

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void IdentifiesNegativeNumberInputs()
        {
            bool ExpectedType = true;
            var testVer = new Verification();

            bool ActualType = testVer.Negative(-1);

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void IdentifiesIfInputIsOutOfRange()
        {
            bool ExpectedType = true;
            var testVer = new Verification();

            bool ActualType = testVer.TooHigh(4000);

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void IdentifiesEmptyStringInputs()
        {
            bool ExpectedType = true;
            var testVer = new Verification();

            bool ActualType = testVer.Empty("");

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void IdentifiesIfInputIsNotAnArabicNumber()
        {
            bool ExpectedType = true;
            var testVer = new Verification();

            bool ActualType = testVer.NotANumber("garbage");

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void Inputting1RetrunsI()
        {
            var ExpectedType = "I";
            var testBuild = new Builder(1);

            var ActualType = testBuild.BuildRomanNumeral();

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void Inputting48ReturnsXLVIII()
        {
            var ExpectedType = "XLVIII";
            var testBuild = new Builder(48);

            var ActualType = testBuild.BuildRomanNumeral();

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void Inputting1682ReturnsMDCLXXXII()
        {
            var ExpectedType = "MDCLXXXII";
            var testBuild = new Builder(1682);

            var ActualType = testBuild.BuildRomanNumeral();

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void Inputting2824ReturnsMMDCCCXXIV()
        {
            var ExpectedType = "MMDCCCXXIV";
            var testBuild = new Builder(2824);

            var ActualType = testBuild.BuildRomanNumeral();

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void Inputting3999ReturnsMMMCMXCIX()
        {
            var ExpectedType = "MMMCMXCIX";
            var testBuild = new Builder(3999);

            var ActualType = testBuild.BuildRomanNumeral();

            Assert.AreEqual(ExpectedType, ActualType);
        }
    }
}
