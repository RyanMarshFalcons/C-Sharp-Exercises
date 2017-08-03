using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consonant_Count;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Consonant_Count_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returnscandycorn()
        {
            var expected = new char[] { 'c', 'a', 'n', 'd', 'y', ' ', 'c', 'o', 'r', 'n' };

            var utility = new Utility();
            var actual = utility.ConvertToCharArray("candy corn");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returnstheregoesthefun()
        {
            var expected = new char[] { 't', 'h', 'e', 'r', 'e', ' ', 'g', 'o', 'e', 's', ' ', 't', 'h', 'e', ' ', 'f', 'u', 'n' };

            var utility = new Utility();
            var actual = utility.ConvertToCharArray("there goes the fun");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns8Forwhostheboss()
        {
            var expected = 8;

            var utility = new Utility();
            var actual = utility.CountConsonantsInArray(new char[] { 'W', 'h', 'o', '\'', 's', ' ', 't', 'h', 'e', ' ', 'b', 'o', 's', 's' });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns11Forwheresthebeefwendy()
        {
            var expected = 11;

            var utility = new Utility();
            var actual = utility.CountConsonantsInArray(new char[] { 'W', 'h', 'e', 'r', 'e', '\'', 's', ' ', 't', 'h', 'e', ' ', 'b', 'e', 'e', 'f', 'W', 'e', 'n', 'd', 'y', '?' });

            Assert.AreEqual(expected, actual);
        }
    }
}
