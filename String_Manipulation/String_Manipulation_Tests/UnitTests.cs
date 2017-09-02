using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Manipulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String_Manipulation_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForMet()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsTooShort("Met");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForMets()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsTooShort("Mets");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForA()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForB()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForC()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForD()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForE()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForF()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForG()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForH()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("H");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForI()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("I");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForJ()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("J");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForK()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("K");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForL()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("L");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForM()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("M");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForN()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("N");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForO()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("O");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFrontBackForA()
        {
            var expected = Manipulation.Front_Back;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFrontAroundForB()
        {
            var expected = Manipulation.Front_Around;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsBackAroundForC()
        {
            var expected = Manipulation.Back_Around;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsMiddleAroundForD()
        {
            var expected = Manipulation.Middle_Around;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFirst3Times3ForE()
        {
            var expected = Manipulation.First_3_Times_3;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsLast3Times3ForF()
        {
            var expected = Manipulation.Last_3_Times_3;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFirst3UppercaseForG()
        {
            var expected = Manipulation.First_3_Uppercase;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsLast3UppercaseForH()
        {
            var expected = Manipulation.Last_3_Uppercase;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("H");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsDoubleCharactersForI()
        {
            var expected = Manipulation.Double_Characters;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("I");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTripleCharactersForJ()
        {
            var expected = Manipulation.Triple_Characters;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("J");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsReverseStringForK()
        {
            var expected = Manipulation.Reverse_String;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("K");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsExplodeStringForL()
        {
            var expected = Manipulation.Explode_String;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("L");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsSwapCasesForM()
        {
            var expected = Manipulation.Swap_Cases;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("M");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsShiftThirdForN()
        {
            var expected = Manipulation.Shift_Third;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("N");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsnyaRForRyan()
        {
            var expected = "nyaR";

            var utility = new Utility();
            var actual = utility.FrontBack("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsharsMForMarsh()
        {
            var expected = "harsM";

            var utility = new Utility();
            var actual = utility.FrontBack("Marsh");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRRyanRRForRyan()
        {
            var expected = "RRyanR";

            var utility = new Utility();
            var actual = utility.FrontAround("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsMMarshMForMarsh()
        {
            var expected = "MMarshM";

            var utility = new Utility();
            var actual = utility.FrontAround("Marsh");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsnRyannForRyan()
        {
            var expected = "nRyann";

            var utility = new Utility();
            var actual = utility.BackAround("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnshMarshhForMarsh()
        {
            var expected = "hMarshh";

            var utility = new Utility();
            var actual = utility.BackAround("Marsh");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsyaRyanyaForRyan()
        {
            var expected = "yaRyanya";

            var utility = new Utility();
            var actual = utility.MiddleAround("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsrMarshrForMarsh()
        {
            var expected = "rMarshr";

            var utility = new Utility();
            var actual = utility.MiddleAround("Marsh");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRyaRyaRyaForRyan()
        {
            var expected = "RyaRyaRya";

            var utility = new Utility();
            var actual = utility.FirstThree3Times("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsMarMarMarForMarsh()
        {
            var expected = "MarMarMar";

            var utility = new Utility();
            var actual = utility.FirstThree3Times("Marsh");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsyanyanyanForRyan()
        {
            var expected = "yanyanyan";

            var utility = new Utility();
            var actual = utility.LastThree3Times("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsrshrshrshForMarsh()
        {
            var expected = "rshrshrsh";

            var utility = new Utility();
            var actual = utility.LastThree3Times("Marsh");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRYAnForRyan()
        {
            var expected = "RYAn";

            var utility = new Utility();
            var actual = utility.FirstThreeUppercase("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsMARshForMarsh()
        {
            var expected = "MARsh";

            var utility = new Utility();
            var actual = utility.FirstThreeUppercase("Marsh");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRYANForRyan()
        {
            var expected = "RYAN";

            var utility = new Utility();
            var actual = utility.LastThreeUppercase("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsMaRSHForMarsh()
        {
            var expected = "MaRSH";

            var utility = new Utility();
            var actual = utility.LastThreeUppercase("Marsh");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRRyyaannForRyan()
        {
            var expected = "RRyyaann";

            var utility = new Utility();
            var actual = utility.DoubleCharacters("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsMMaarrsshhForMarsh()
        {
            var expected = "MMaarrsshh";

            var utility = new Utility();
            var actual = utility.DoubleCharacters("Marsh");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRRRyyyaaannnForRyan()
        {
            var expected = "RRRyyyaaannn";

            var utility = new Utility();
            var actual = utility.TripleCharacters("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsMMMaaarrrssshhhForMarsh()
        {
            var expected = "MMMaaarrrssshhh";

            var utility = new Utility();
            var actual = utility.TripleCharacters("Marsh");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsnayRForRyan()
        {
            var expected = "nayR";

            var utility = new Utility();
            var actual = utility.ReverseString("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnshsraMForMarsh()
        {
            var expected = "hsraM";

            var utility = new Utility();
            var actual = utility.ReverseString("Marsh");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRRyRyaRyanForRyan()
        {
            var expected = "RRyRyaRyan";

            var utility = new Utility();
            var actual = utility.StringExplosion("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsMMaMarMarsMarshForMarsh()
        {
            var expected = "MMaMarMarsMarsh";

            var utility = new Utility();
            var actual = utility.StringExplosion("Marsh");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsrYANForRyan()
        {
            var expected = "rYAN";

            var utility = new Utility();
            var actual = utility.SwapCases("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsmARSHForMarsh()
        {
            var expected = "mARSH";

            var utility = new Utility();
            var actual = utility.SwapCases("Marsh");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsyaRForRyan()
        {
            var expected = "yaR";

            var utility = new Utility();
            var actual = utility.ShiftThird("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsarMForMarsh()
        {
            var expected = "arM";

            var utility = new Utility();
            var actual = utility.ShiftThird("Marsh");

            Assert.AreEqual(expected, actual);
        }
    }
}
