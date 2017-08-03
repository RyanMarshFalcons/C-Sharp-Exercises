using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character_Count;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Character_Count_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returnscatinthehat()
        {
            var expected = new char[] { 'c', 'a', 't', ' ', 'i', 'n', ' ', 't', 'h', 'e', ' ', 'h', 'a', 't' };

            var utility = new Utility();
            var actual = utility.ConvertToCharArray("cat in the hat");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsGibberish129er()
        {
            var expected = new char[] { 'G', 'i', 'b', 'b', 'e', 'r', 'i', 's', 'h', '1', '2', '9', 'e', 'r', '*', '&', '(', '#', 'Q', '@', '#', '!', '!', '!' };

            var utility = new Utility();
            var actual = utility.ConvertToCharArray("Gibberish129er*&(#Q@#!!!");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns5ForHello()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.CountCharsInArray(new char[] { 'H', 'e', 'l', 'l', 'o' });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns24ForIran3MilesToday()
        {
            var expected = 20;

            var utility = new Utility();
            var actual = utility.CountCharsInArray(new char[] { 'I', ' ', 'r', 'a', 'n', ' ', '3', ' ', 'm', 'i', 'l', 'e', 's', ' ', 't', 'o', 'd', 'a', 'y', '!' });

            Assert.AreEqual(expected, actual);
        }
    }
}
