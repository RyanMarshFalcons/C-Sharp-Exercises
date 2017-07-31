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
        public void returnsFalseFordog()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("dog");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsTrueFor7point38()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("7.38");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsTrueFory()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("y");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsTrueForn()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("n");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsFalseForx()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("x");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returns30For252639()
        {
            var expected = 30;

            var utility = new Utility();
            var actual = utility.FindTheMean(new List<double>() { 25, 26, 39 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returns6point33For6point277point882point468point72()
        {
            var expected = 6.33;

            var utility = new Utility();
            var actual = utility.FindTheMean(new List<double>() { 6.27, 7.88, 2.46, 8.72 });

            Assert.AreEqual(expected, actual);
        }
    }
}
