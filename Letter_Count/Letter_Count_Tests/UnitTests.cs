using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Letter_Count;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Letter_Count_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returns3wood9iron()
        {
            var expected = new char[] { '3', ' ', 'w', 'o', 'o', 'd', ' ', '9', ' ', 'i', 'r', 'o', 'n' };

            var utility = new Utility();
            var actual = utility.ConvertToCharArray("3 wood 9 iron");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returnscounttothree123()
        {
            var expected = new char[] { 'c', 'o', 'u', 'n', 't', ' ', 't', 'o', ' ', 't', 'h', 'r', 'e', 'e', ' ', '1', '2', '3' };

            var utility = new Utility();
            var actual = utility.ConvertToCharArray("count to three 123");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns12Foralphabet()
        {
            var expected = 8;

            var utility = new Utility();
            var actual = utility.CountLettersInArray(new char[] { 'a', 'l', 'p', 'h', 'a', 'b', 'e', 't' });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns10Forkablamajam123()
        {
            var expected = 10;

            var utility = new Utility();
            var actual = utility.CountLettersInArray(new char[] { 'k', 'a', 'b', 'l', 'a', 'm', 'a', 'j', 'a', 'm', '1', '2', '3' });

            Assert.AreEqual(expected, actual);
        }
    }
}
