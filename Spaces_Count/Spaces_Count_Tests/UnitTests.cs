using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spaces_Count;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Spaces_Count_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returnspiginablacket()
        {
            var expected = new char[] { 'p', 'i', 'g', ' ', 'i', 'n', ' ', 'a', ' ', 'b', 'l', 'a', 'n', 'k', 'e', 't' };

            var utility = new Utility();
            var actual = utility.ConvertToCharArray("pig in a blanket");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returnsyellowdog()
        {
            var expected = new char[] { 'y', 'e', 'l', 'l', 'o', 'w', ' ', 'd', 'o', 'g' };

            var utility = new Utility();
            var actual = utility.ConvertToCharArray("yellow dog");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2ForsamIam()
        {
            var expected = 2;

            var utility = new Utility();
            var actual = utility.CountSpacesInArray(new char[] { 'S', 'a', 'm', ' ', 'I', ' ', 'a', 'm' });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns7Foronefishtwofishredfishbluefish()
        {
            var expected = 7;

            var utility = new Utility();
            var actual = utility.CountSpacesInArray(new char[] { 'o', 'n', 'e', ' ', 'f', 'i', 's', 'h', ' ', 't', 'w', 'o', ' ', 'f', 'i', 's', 'h', ' ', 'r', 'e', 'd', ' ', 'f', 'i', 's', 'h', ' ', 'b', 'l', 'u', 'e', ' ', 'f', 'i', 's', 'h' });

            Assert.AreEqual(expected, actual);
        }
    }
}
