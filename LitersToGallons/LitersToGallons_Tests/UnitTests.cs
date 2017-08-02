using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitersToGallons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LitersToGallons_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForIowa()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Iowa");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor42point89()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("42.89");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative63point24()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-63.24");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor63point24()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("63.24");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0point79For3()
        {
            var expected = 0.79;

            var utility = new Utility();
            var actual = utility.GetGallons(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns7point12For27point128()
        {
            var expected = 7.17;

            var utility = new Utility();
            var actual = utility.GetGallons(27.128);

            Assert.AreEqual(expected, actual);
        }

    }
}
