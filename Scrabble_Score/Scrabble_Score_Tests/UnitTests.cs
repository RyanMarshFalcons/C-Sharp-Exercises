using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scrabble_Score;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Scrabble_Score_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void AnEmptyStringIsTooShort()
        {
        var expected = true;

        var utility = new Utility();
        var actual = utility.CheckIfTooShort("");

        Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AOneLetterWordsNotTooShort()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("I");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ASixteenLetterWordIsTooLong()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooLong("Anesthesiologist");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AFifteenLetterWordIsNotTooLong()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooLong("Prognostication");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RyanExclamationPointContainsNonLetter()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.ContainsOnlyLetters("Ryan!");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SpaceRyanContainsNonLetter()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.ContainsOnlyLetters(" Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RyQuestionMarksanContainsNonLetter()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.ContainsOnlyLetters("Ry??an");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RyanContainsOnlyLetters()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.ContainsOnlyLetters("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BaseValueForTheWorda()
        {
            var expected = new int[] { 1 };

            var utility = new Utility();
            var actual = utility.CalculateBaseValues("a");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BaseValuesForTheWordat()
        {
            var expected = new int[] { 1, 1 };

            var utility = new Utility();
            var actual = utility.CalculateBaseValues("at");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BaseValuesForTheWordZoo()
        {
            var expected = new int[] { 10, 1, 1 };

            var utility = new Utility();
            var actual = utility.CalculateBaseValues("Zoo");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BaseValuesForTheWordQuirky()
        {
            var expected = new int[] { 10, 1, 1, 1, 5, 4 };

            var utility = new Utility();
            var actual = utility.CalculateBaseValues("Quirky");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BaseValuesForTheWordOxyphenButazone()
        {
            var expected = new int[] { 1, 8, 4, 3, 4, 1, 1, 3, 1, 1, 1, 10, 1, 1, 1 };

            var utility = new Utility();
            var actual = utility.CalculateBaseValues("OxyphenButazone");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FIsNotAValidSelection()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ARepresentsARegularSquare()
        {
            var expected = SquareType.Regular;

            var utility = new Utility();
            var actual = utility.ConvertSelectionLetterToSquareType("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BRepresentsADoubleLetterSquare()
        {
            var expected = SquareType.DoubleLetter;

            var utility = new Utility();
            var actual = utility.ConvertSelectionLetterToSquareType("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CRepresentsATripleLetterSquare()
        {
            var expected = SquareType.TripleLetter;

            var utility = new Utility();
            var actual = utility.ConvertSelectionLetterToSquareType("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DRepresentsADoubleWordSquare()
        {
            var expected = SquareType.DoubleWord;

            var utility = new Utility();
            var actual = utility.ConvertSelectionLetterToSquareType("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ERepresentsATripleWordSquare()
        {
            var expected = SquareType.TripleWord;

            var utility = new Utility();
            var actual = utility.ConvertSelectionLetterToSquareType("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTheCorrectWordScoreOf5()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.CalculateWordScore(new int[] { 1, 2 }, new SquareType[] { SquareType.Regular, SquareType.DoubleLetter });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTheCorrectWordScoreOf144()
        {
            var expected = 144;

            var utility = new Utility();
            var actual = utility.CalculateWordScore(new int[] { 3, 5, 10, 2 }, new SquareType[] { SquareType.TripleWord, SquareType.Regular, SquareType.DoubleWord, SquareType.TripleLetter });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTheCorrectWordScoreOf82()
        {
            var expected = 82;

            var utility = new Utility();
            var actual = utility.CalculateWordScore(new int[] { 2, 1, 1, 5, 8, 10, 4 }, new SquareType[] { SquareType.DoubleLetter, SquareType.Regular, SquareType.Regular, SquareType.Regular, SquareType.Regular, SquareType.DoubleWord, SquareType.TripleLetter });

            Assert.AreEqual(expected, actual);
        }
    }
}
