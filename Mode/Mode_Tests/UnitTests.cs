using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mode_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor12point7()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("12.7");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForelephant()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("elephant");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFory()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("y");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForn()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("n");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForg()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("g");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3For3InstancesOf1point2()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.GetMaxCount(new List<double>() { 1.2, 1.3, 1.2, 1.4, 1.2 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4For4InstancesOf1point2and1point3()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.GetMaxCount(new List<double>() { 1.2, 1.3, 1.2, 1.4, 1.2, 1.3, 1.3, 1.2, 1.3 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1point2For3InstancesOf1point2()
        {
            var expected = new List<double>() { 1.2 };

            var utility = new Utility();
            var actual = utility.FindTheMode(3, new List<double>() { 1.2, 1.3, 1.2, 1.4, 1.2 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1point2And1point3For3InstancesOf1point2and1point3()
        {
            var expected = new List<double>() { 1.2, 1.3 };

            var utility = new Utility();
            var actual = utility.FindTheMode(3, new List<double>() { 1.2, 1.3, 1.2, 1.4, 1.2, 1.3, 1.3, 1.2, 1.3 });

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
