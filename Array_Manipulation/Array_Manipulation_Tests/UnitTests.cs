using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array_Manipulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Array_Manipulation_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor8()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("8");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForH()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("H");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FormatsArrayAsString()
        {
            var expected = "[1] [2] [3] [4] [5] [6] [7] ";

            var utility = new Utility();
            var actual = utility.ArrayAsString(new int[] { 1, 2, 3, 4, 5, 6, 7 });

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
        public void ReturnsFalseForM()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("M");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsSortLowestToHighestForA()
        {
            var expected = Manipulation.Sort_Lowest_To_Highest;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsSortHighestToLowestForB()
        {
            var expected = Manipulation.Sort_Highest_To_Lowest;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsAdd2ToAllForC()
        {
            var expected = Manipulation.Add_2_To_All;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsAdd3ToOddForD()
        {
            var expected = Manipulation.Add_3_To_Odd;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsAdd4ToEvenForE()
        {
            var expected = Manipulation.Add_4_To_Even;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsMultiplyAllBy5ForF()
        {
            var expected = Manipulation.Multiply_All_By_5;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsReplaceHighestWithLowestForG()
        {
            var expected = Manipulation.Replace_Highest_With_Lowest;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsReplaceLowestWithHighestForH()
        {
            var expected = Manipulation.Replace_Lowest_With_Highest;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("H");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsShiftLeftForI()
        {
            var expected = Manipulation.Shift_Left;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("I");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsShiftRightForJ()
        {
            var expected = Manipulation.Shift_Right;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("J");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsMinus10TripleForK()
        {
            var expected = Manipulation.Minus_10_Triple;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("K");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsMinus20QuadrupleForL()
        {
            var expected = Manipulation.Minus_20_Quadruple;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("L");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SortsArrayFromLowestToHighest()
        {
            var expected = new int[] { 1, 2, 3, 4, 5 };

            var utility = new Utility();
            var actual = utility.SortLowestToHighest(new int[] { 2, 1, 4, 5, 3 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SortsArrayFromHighestToLowest()
        {
            var expected = new int[] { 5, 4, 3, 2, 1 };

            var utility = new Utility();
            var actual = utility.SortHighestToLowest(new int[] { 2, 1, 4, 5, 3 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Adds2ToAllNumbersInArray()
        {
            var expected = new int[] { 4, 3, 6, 7, 5 };

            var utility = new Utility();
            var actual = utility.AddTwoToAll(new int[] { 2, 1, 4, 5, 3 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Adds3ToAllOddNumbersInArray()
        {
            var expected = new int[] { 2, 4, 4, 8, 6 };

            var utility = new Utility();
            var actual = utility.AddThreeToOdd(new int[] { 2, 1, 4, 5, 3 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Adds4ToAllEvenNumbersInArray()
        {
            var expected = new int[] { 6, 1, 8, 5, 3 };

            var utility = new Utility();
            var actual = utility.AddFourToEvens(new int[] { 2, 1, 4, 5, 3 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultipliesAllNumbersInArrayBy5()
        {
            var expected = new int[] { 10, 5, 20, 25, 15 };

            var utility = new Utility();
            var actual = utility.MultiplyAllByFive(new int[] { 2, 1, 4, 5, 3 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetsHighestNumberInArray()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.GetHighest(new int[] { 2, 1, 4, 5, 3 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetsLowestNumberInArray()
        {
            var expected = 1;

            var utility = new Utility();
            var actual = utility.GetLowest(new int[] { 2, 1, 4, 5, 3 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReplacesHighestNumberWithLowestNumberInArray()
        {
            var expected = new int[] { 2, 1, 4, 1, 3 };

            var utility = new Utility();
            var actual = utility.ReplaceHighestWithLowest(new int[] { 2, 1, 4, 5, 3 }, 5, 1);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReplacesLowestNumberWithHighestNumberInArray()
        {
            var expected = new int[] { 2, 5, 4, 5, 3 };

            var utility = new Utility();
            var actual = utility.ReplaceLowestWithHighest(new int[] { 2, 1, 4, 5, 3 }, 5, 1);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShiftsAllTheNumbersInTheArrayLeft()
        {
            var expected = new int[] { 1, 4, 5, 3, 2 };

            var utility = new Utility();
            var actual = utility.ShiftLeft(new int[] { 2, 1, 4, 5, 3 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShiftsAllTheNumbersInTheArrayRight()
        {
            var expected = new int[] { 3, 2, 1, 4, 5 };

            var utility = new Utility();
            var actual = utility.ShiftRight(new int[] { 2, 1, 4, 5, 3 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtracts10FromAndThenTriplesEveryNumberInTheArray()
        {
            var expected = new int[] { -24, -27, -18, -15, -21 };

            var utility = new Utility();
            var actual = utility.MinusTenTriple(new int[] { 2, 1, 4, 5, 3 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtracts20FromAndThenQuadrupleslesEveryNumberInTheArray()
        {
            var expected = new int[] { -72, -76, -64, -60, -68 };

            var utility = new Utility();
            var actual = utility.MinusTwentyQuadruple(new int[] { 2, 1, 4, 5, 3 });

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
