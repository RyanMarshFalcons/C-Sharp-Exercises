using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Super_Reduced_String;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Super_Reduced_String_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void EmptyStringTooShort()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneCharacterStringTooShort()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoCharacterStringLongEnough()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("AA");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ThreeCharacterStringLongEnough()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("AAA");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringThatCantBeSuperReduced()
        {
            var expected = new ReducedString() { RemainingCharacters = "abcd", TimesReduced = 0 };

            var utility = new Utility();
            var actual = utility.ReduceUserString("abcd");

            Assert.AreEqual(expected.RemainingCharacters, actual.RemainingCharacters);
            Assert.AreEqual(expected.TimesReduced, actual.TimesReduced);
        }

        [TestMethod]
        public void StringThatGetsSuperReducedToNothing()
        {
            var expected = new ReducedString() { RemainingCharacters = "", TimesReduced = 4 };

            var utility = new Utility();
            var actual = utility.ReduceUserString("abbaccdd");

            Assert.AreEqual(expected.RemainingCharacters, actual.RemainingCharacters);
            Assert.AreEqual(expected.TimesReduced, actual.TimesReduced);
        }

        [TestMethod]
        public void StringThatGetsSuperReducedSome()
        {
            var expected = new ReducedString() { RemainingCharacters = "1efg1", TimesReduced = 7 };

            var utility = new Utility();
            var actual = utility.ReduceUserString("1abbaefgccddeefggf1");

            Assert.AreEqual(expected.RemainingCharacters, actual.RemainingCharacters);
            Assert.AreEqual(expected.TimesReduced, actual.TimesReduced);
        }
    }
}
