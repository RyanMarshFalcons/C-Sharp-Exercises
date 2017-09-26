using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotational_Cipher;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rotational_Cipher_Tests
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
        public void OneLetterIsNotTooShort()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("T");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StarStarStargStarStarStarContainsALetter()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfContainsAnyLetters("***g***");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RyanIsAwesomeContainsLetters()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfContainsAnyLetters("Ryan is awesome");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StarStarStarStarStarStarStarDoesNotContainALetter()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfContainsAnyLetters("*******");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FifteenIsAnInteger()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("15");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DIsNotAnInteger()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZeroIsOutOfRange()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfOutOfRange("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneIsNotOutOfRange()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfOutOfRange("1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwentySixIsOutOfRange()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfOutOfRange("26");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwentyFiveIsInRange()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfOutOfRange("25");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RotatesLettersBy5LeavesExclamationPointsUntouched()
        {
            var expected = "TRL!!!";

            var utility = new Utility();
            var actual = utility.EncryptMessage("OMG!!!", 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RotatesLettersBy4LeavesSpacesAndNumbersUntouched()
        {
            var expected = "Xiwxmrk 1 2 3 xiwxmrk";

            var utility = new Utility();
            var actual = utility.EncryptMessage("Testing 1 2 3 testing", 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RotatesLettersBy21LeavesSpacesAndPunctuationUntouched()
        {
            var expected = "Gzo'n zvo, Bmviyhv!";

            var utility = new Utility();
            var actual = utility.EncryptMessage("Let's eat, Grandma!", 21);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RotatesLettersBy13LeavesSpacesAndPunctuationUntouched()
        {
            var expected = "Gur dhvpx oebja sbk whzcf bire gur ynml qbt.";

            var utility = new Utility();
            var actual = utility.EncryptMessage("The quick brown fox jumps over the lazy dog.", 13);

            Assert.AreEqual(expected, actual);
        }
    }
}
