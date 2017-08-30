using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Famous_Sequences;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Famous_Sequences_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForA()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForB()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForC()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForD()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForE()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsSequenceFibonacciForA()
        {
            var expected = Sequence.Fibonacci;

            var utility = new Utility();
            var actual = utility.ConvertToSequence("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsSequenceLazyCatererForB()
        {
            var expected = Sequence.LazyCaterer;

            var utility = new Utility();
            var actual = utility.ConvertToSequence("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsSequenceRectangularForC()
        {
            var expected = Sequence.Rectangular;

            var utility = new Utility();
            var actual = utility.ConvertToSequence("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsSequenceTriangularForD()
        {
            var expected = Sequence.Triangular;

            var utility = new Utility();
            var actual = utility.ConvertToSequence("D");

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Returns8For011235()
        {
            var expected = 8;

            var utility = new Utility();
            var actual = utility.FibonacciNextNumber(new List<int>() { 0, 1, 1, 2, 3, 5 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns8For011235813()
        {
            var expected = 21;

            var utility = new Utility();
            var actual = utility.FibonacciNextNumber(new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns8For0112358132134()
        {
            var expected = 55;

            var utility = new Utility();
            var actual = utility.FibonacciNextNumber(new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns16For5()
        {
            var expected = 16;

            var utility = new Utility();
            var actual = utility.LazyCatererNextNumber(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns79For12()
        {
            var expected = 79;

            var utility = new Utility();
            var actual = utility.LazyCatererNextNumber(12);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns277For23()
        {
            var expected = 277;

            var utility = new Utility();
            var actual = utility.LazyCatererNextNumber(23);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns30For5()
        {
            var expected = 30;

            var utility = new Utility();
            var actual = utility.RectangularNextNumber(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns156For12()
        {
            var expected = 156;

            var utility = new Utility();
            var actual = utility.RectangularNextNumber(12);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns552For23()
        {
            var expected = 552;

            var utility = new Utility();
            var actual = utility.RectangularNextNumber(23);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns15For5()
        {
            var expected = 15;

            var utility = new Utility();
            var actual = utility.TriangularNextNumber(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns78For12()
        {
            var expected = 78;

            var utility = new Utility();
            var actual = utility.TriangularNextNumber(12);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns276For23()
        {
            var expected = 276;

            var utility = new Utility();
            var actual = utility.TriangularNextNumber(23);

            Assert.AreEqual(expected, actual);
        }
    }
}
