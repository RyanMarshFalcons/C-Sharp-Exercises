using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Symbol_Count;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Symbol_Count_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returnsdeserteagle()
        {
            var expected = new char[] { 'd', 'e', 's', 'e', 'r', 't', ' ', 'e', 'a', 'g', 'l', 'e' };

            var utility = new Utility();
            var actual = utility.ConvertToCharArray("desert eagle");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returnsherecomestherain()
        {
            var expected = new char[] { 'h', 'e', 'r', 'e', ' ', 'c', 'o', 'm', 'e', 's', ' ', 't', 'h', 'e', ' ', 'r', 'a', 'i', 'n', '!' };

            var utility = new Utility();
            var actual = utility.ConvertToCharArray("here comes the rain!");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4Forhesinatapt4()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.CountSymbolsInArray(new char[] { 'H', 'e', '\'', 's', ' ', 'i', 'n', ' ', '@', ' ', 'a', 'p', 't', '#', '4' });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returnssymbolmessage()
        {
            var expected = 9;

            var utility = new Utility();
            var actual = utility.CountSymbolsInArray(new char[] { '$', ' ', '@', ' ', '*', 's', ' ', '&', ' ', '%', '#', 's', '!', '!', '!' });

            Assert.AreEqual(expected, actual);
        }
    }
}
