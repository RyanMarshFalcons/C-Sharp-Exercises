using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mix_String;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mix_String_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForEmptyString()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForG()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3Forcarautomobile()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.GetShorterStringLength("car", "automobile");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3Forgreyhoundbusses()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.GetShorterStringLength("greyhound", "buses");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRMyaarnshallForRyanMarshall()
        {
            var expected = "RMyaarnshall";

            var utility = new Utility();
            var actual = utility.MixStringsTogether("Ryan", "Marshall", 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnspkoisdterForposterkid()
        {
            var expected = "pkoisdter";

            var utility = new Utility();
            var actual = utility.MixStringsTogether("poster", "kid", 3);

            Assert.AreEqual(expected, actual);
        }
    }
}
