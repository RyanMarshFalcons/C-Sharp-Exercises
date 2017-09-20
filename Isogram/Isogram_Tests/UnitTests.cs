using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Isogram;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Isogram_Tests
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
        public void SIsNotTooShort()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsTooShort("S");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringWithNoLetters()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.ContainsNoLetters("465 4$%    $&^$%  &65   4");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringHasALetter()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.ContainsNoLetters("465 4$%    $&^$%  &65   4f");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringHasLotsOfLetters()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.ContainsNoLetters("dfgdf   gdsf    gdfsg  df");
             
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void RemovesNonLetterCharactersFromString()
        {
            var expected = "QFCkfc";

            var utility = new Utility();
            var actual = utility.RemoveNonLetters("QFC   123 !-2342 kfc 5644#   #$#4165491");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CapitalizesAllOfTheLettersInTheString()
        {
            var expected = "RYANISAWESOME";

            var utility = new Utility();
            var actual = utility.CapitalizeAllLetters("Ryanisawesome");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemovesDuplicateLettersFromString()
        {
            var expected = "QFRABCD";

            var utility = new Utility();
            var actual = utility.RemoveDuplicates("QFFFRRRRFFRRRRABBQQQABBAACCCAAABBCCDDAAACCDDA");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HadDuplicateLetters()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsIsogram("RYANISAWESOME", "RYANISWEOM");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HadOnlyUniqueLetters()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsIsogram("RYANIS", "RYANIS");

            Assert.AreEqual(expected, actual);
        }
    }
}
