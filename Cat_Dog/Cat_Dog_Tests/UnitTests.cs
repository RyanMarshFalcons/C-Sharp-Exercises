using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cat_Dog;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cat_Dog_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForAB()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("AB");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForABC()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("ABC");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3Forhaddogadasdfdogadsdogadfv()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.GetCount("haddogadasdfdogacatdsdogadfv", "dog");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3Forcatasdfjcataweruhwecatasdje3aecatasdclkjh()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.GetCount("dogcatasdfjcataweruhwecatasdje3aecatasdclkjh", "cat");

            Assert.AreEqual(expected, actual);
        }
    }
}
