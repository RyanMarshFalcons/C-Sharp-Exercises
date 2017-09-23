using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pig_Latin;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pig_Latin_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForEmptyString()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsTooShort("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForQ()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsTooShort("Q");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueIfBeginsWithALetter()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfBeginsWithALetter("abracadabra");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseIfDoesntBeginWithALetter()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfBeginsWithALetter("3abracadabra");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueIfBeginsWithVowel()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfBeginsWithVowel("apple");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseIfBeginsWithConsonant()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfBeginsWithVowel("pineapple");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void aIsAVowel()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfVowel('a');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void eIsAVowel()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfVowel('e');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void iIsAVowel()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfVowel('i');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void oIsAVowel()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfVowel('o');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void uIsAVowel()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfVowel('u');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void yIsAVowel()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfVowel('y');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AIsAVowel()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfVowel('A');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EIsAVowel()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfVowel('E');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IIsAVowel()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfVowel('I');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OIsAVowel()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfVowel('O');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UIsAVowel()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfVowel('U');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void YIsAVowel()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfVowel('Y');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void tIsNotAVowel()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfVowel('t');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TIsNotAVowel()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfVowel('T');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsIdahoyayForIdaho()
        {
            var expected = "Idahoyay";

            var utility = new Utility();
            var actual = utility.AddYayToTheEnd("Idaho");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsEerschForcheers()
        {
            var expected = "eersch";

            var utility = new Utility();
            var actual = utility.MoveConsonantsToTheEnd("cheers");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3Forsplat()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.ConsonantCounter("splat");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsIckayForick()
        {
            var expected = "ickay";

            var utility = new Utility();
            var actual = utility.AddAyToTheEnd("ick");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsyanRayisyayayayoolcayuygayForRyanisacoolguy()
        {
            var expected = "yanRay isyay ayay oolcay uygay";

            var utility = new Utility();
            var actual = utility.TranslateToPigLatin("Ryan is a cool guy.");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsitSayUbuyayitsayoodGayogdayForRyanSitUbusitGooddog()
        {
            var expected = "itSay Ubuyay itsay oodGay ogday";

            var utility = new Utility();
            var actual = utility.TranslateToPigLatin("Sit Ubu sit. Good dog.");

            Assert.AreEqual(expected, actual);
        }
    }
}
