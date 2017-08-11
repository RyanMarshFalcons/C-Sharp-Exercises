using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neptune;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Neptune_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForA()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsABCD("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForB()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsABCD("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForC()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsABCD("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForD()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsABCD("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForN()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsABCD("N");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForHati()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Hati");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor34point25()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("34.25");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor107point7()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("107.7");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative107point7()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("-107.7");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns196For175()
        {
            var expected = 196;

            var utility = new Utility();
            var actual = utility.GetWeightOnNeptune(175);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns11point61For13()
        {
            var expected = 11.61;

            var utility = new Utility();
            var actual = utility.GetVerticalLeapOnNeptune(13);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0point18For30()
        {
            var expected = 0.18;

            var utility = new Utility();
            var actual = utility.GetAgeOnNeptune(30);

            Assert.AreEqual(expected, actual);
        }
    }
}
