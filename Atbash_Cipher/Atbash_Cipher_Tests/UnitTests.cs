using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atbash_Cipher;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Atbash_Cipher_Tests
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
            var actual = utility.CheckIfTooShort("Q");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StarStarStarLStarStarStarContainsALetter()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfContainsAnyLetters("***L***");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RyanIsSuperCoolContainsLetters()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfContainsAnyLetters("Ryan is super cool");

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
        public void ConvertsyesTobvh()
        {
            var expected = "bvh";

            var utility = new Utility();
            var actual = utility.EncryptMessage("yes");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertsOMGtoLNT()
        {
            var expected = "LNT";

            var utility = new Utility();
            var actual = utility.EncryptMessage("OMG");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertsmindblowinglyTonrmwyoldrmtob()
        {
            var expected = "nrmw yoldrmtob";

            var utility = new Utility();
            var actual = utility.EncryptMessage("mind blowingly");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertsTesting123testingTogvhgrmt123gvhgrmt()
        {
            var expected = "Gvhgrmt, 1, 2, 3, gvhgrmt.";

            var utility = new Utility();
            var actual = utility.EncryptMessage("Testing, 1, 2, 3, testing.");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertsThequickbrownfoxjumpsoverthelazydogToGsvjfrxpyildmulcqfnkhlevigsvozabwlt()
        {
            var expected = "Gsv jfrxp yildm ulc qfnkh levi gsv ozab wlt.";

            var utility = new Utility();
            var actual = utility.EncryptMessage("The quick brown fox jumps over the lazy dog.");

            Assert.AreEqual(expected, actual);
        }
    }
}
