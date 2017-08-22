using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weight_Conversions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Weight_Conversions_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForA()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfABCD("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForB()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfABCD("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForC()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfABCD("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForD()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfABCD("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForE()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfABCD("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForAlabama()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Alabama");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor12point289()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("12.289");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative16point12()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-16.12");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor16point12()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("16.12");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1point48For42()
        {
            var expected = 1.48;

            var utility = new Utility();
            var actual = utility.GetOunces(42);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns31point99For907()
        {
            var expected = 31.99;

            var utility = new Utility();
            var actual = utility.GetOunces(907);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns85point05For3()
        {
            var expected = 85.05;

            var utility = new Utility();
            var actual = utility.GetGrams(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns509point75For17point981()
        {
            var expected = 509.75;

            var utility = new Utility();
            var actual = utility.GetGrams(17.981);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns11point02For5()
        {
            var expected = 11.02;

            var utility = new Utility();
            var actual = utility.GetPounds(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns125point49For56point922()
        {
            var expected = 125.49;

            var utility = new Utility();
            var actual = utility.GetPounds(56.922);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2point27For5()
        {
            var expected = 2.27;

            var utility = new Utility();
            var actual = utility.GetKilograms(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns49point17For108point396()
        {
            var expected = 49.17;

            var utility = new Utility();
            var actual = utility.GetKilograms(108.396);

            Assert.AreEqual(expected, actual);
        }
    }
}
