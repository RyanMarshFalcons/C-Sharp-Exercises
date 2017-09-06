using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mean_Median_Mode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mean_Median_Mode_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForowl()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("owl");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor7point38()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("7.38");

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
        public void ReturnsFalseForx()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("x");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns30For252639()
        {
            var expected = 30;

            var utility = new Utility();
            var actual = utility.FindTheMean(new List<double>() { 25, 26, 39 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns6point33For6point277point882point468point72()
        {
            var expected = 6.33;

            var utility = new Utility();
            var actual = utility.FindTheMean(new List<double>() { 6.27, 7.88, 2.46, 8.72 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor2()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfEven(2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor3()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfEven(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4For7413652()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.FindTheMedian(7, new List<double>() { 7, 4, 1, 3, 6, 5, 2 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns5point5For1point12point23point34point45point56point67point78point89point9()
        {
            var expected = 5.5;

            var utility = new Utility();
            var actual = utility.FindTheMedian(9, new List<double>() { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9 });

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
