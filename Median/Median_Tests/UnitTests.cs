using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Median;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Median_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForcat()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("cat");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor6point28()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("6.28");

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
        public void ReturnsFalseForm()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("m");

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
            var actual = utility.FindTheMedian(9, new List<double>() {1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9 });

            Assert.AreEqual(expected, actual);
        }
    }
}
