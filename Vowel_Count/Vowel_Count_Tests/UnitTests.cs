using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vowel_Count;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vowel_Count_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returnsdandylion()
        {
            var expected = new char[] { 'd', 'a', 'n', 'd', 'e', 'l', 'i', 'o', 'n' };

            var utility = new Utility();
            var actual = utility.ConvertToCharArray("dandelion");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returnsherecomesthesun()
        {
            var expected = new char[] { 'h', 'e', 'r', 'e', ' ', 'c', 'o', 'm', 'e', 's', ' ', 't', 'h', 'e', ' ', 's', 'u', 'n' };

            var utility = new Utility();
            var actual = utility.ConvertToCharArray("here comes the sun");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4Forhesincharge()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.CountVowelsInArray(new char[] { 'H', 'e', '\'', 's', ' ', 'i', 'n', ' ', 'c', 'h', 'a', 'r', 'g', 'e' });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3For9amEnglish101()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.CountVowelsInArray(new char[] { '9', 'a', 'm', ' ', 'E', 'n', 'g', 'l', 'i', 's', 'h', ' ', '1', '0', '1' });

            Assert.AreEqual(expected, actual);
        }
    }
}
