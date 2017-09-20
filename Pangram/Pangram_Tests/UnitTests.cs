using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pangram;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pangram_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void AnEmptyStringIsTooShort()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsTooShort("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RIsNotTooShort()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsTooShort("R");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemovesNonLetterCharactersFromString()
        {
            var expected = "ABCxyz";

            var utility = new Utility();
            var actual = utility.RemoveNonLetters("ABC   123 !-2342 xyz  41232.4#$@");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CapitalizesAllOfTheLettersInTheString()
        {
            var expected = "RYANISACOOLGUY";

            var utility = new Utility();
            var actual = utility.CapitalizeAllLetters("Ryanisacoolguy");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemovesDuplicateLettersFromString()
        {
            var expected = "ABCD";

            var utility = new Utility();
            var actual = utility.RemoveDuplicates("ABBABBAACCCAAABBCCDDAAACCDDA");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotAPanagram()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsPangram("RYANWENTTOTHESTORE");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsAPanagram()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsPangram("ISCATZREHQKDBPUYGLODFXVMNW");

            Assert.AreEqual(expected, actual);
        }
    }
}
