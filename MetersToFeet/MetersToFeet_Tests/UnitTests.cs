using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetersToFeet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MetersToFeet_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForHawaii()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Hawaii");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor64point548()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("64.548");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative12point73()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-12.73");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor12point73()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("12.73");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns22point97For7()
        {
            var expected = 22.97;

            var utility = new Utility();
            var actual = utility.GetFeet(7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns967point41For294point8651()
        {
            var expected = 967.41;

            var utility = new Utility();
            var actual = utility.GetFeet(294.8651);

            Assert.AreEqual(expected, actual);
        }
    }
}
