using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crypto_Square;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crypto_Square_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void AThreeLetterStringIsTooShort()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("Man");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AFourLetterStringIsNotTooShort()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("Mane");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StarStarStarpStarStarStarContainsALetter()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfContainsAnyLetters("***p***");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RyanIsAmazingContainsLetters()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfContainsAnyLetters("Ryan is amazing");

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
        public void NormalizeHelloMrSmithisit()
        {
            var expected = "hellomrsmithisit";

            var utility = new Utility();
            var actual = utility.NormalizeText("Hello, Mr. Smith is it?");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NormalizeLetsgoBulldogsLetsgo()
        {
            var expected = "letsgobulldogsletsgo";

            var utility = new Utility();
            var actual = utility.NormalizeText("Let's go Bulldogs! Let's go!");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetWidthOf4CharacterString()
        {
            var expected = 2;

            var utility = new Utility();
            var actual = utility.GetWidth("bill");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetWidthOf20CharacterString()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.GetWidth("billnyethescienceguy");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MakebillACryptoSquare()
        {
            var expected = new List<string>() { "bi", "ll"};

            var utility = new Utility();
            var actual = utility.ConstructRows("bill", 2);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MakebillnyethescienceguyACryptoSquare()
        {
            var expected = new List<string>() { "billn", "yethe", "scien", "ceguy" };

            var utility = new Utility();
            var actual = utility.ConstructRows("billnyethescienceguy", 5);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
