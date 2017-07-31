using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mean;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Mean_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseFordog()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("dog");

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
    }
}
