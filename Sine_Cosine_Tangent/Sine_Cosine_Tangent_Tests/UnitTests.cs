using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sine_Cosine_Tangent;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sine_Cosine_Tangent_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor9point46()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("9.46");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForcat()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("cat");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForA()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfSinCosTan("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForB()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfSinCosTan("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForC()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfSinCosTan("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForD()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfSinCosTan("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsPoint14For3()
        {
            var expected = .14;
            var utility = new Utility();
            var actual = utility.GetSine(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsNegativePoint38For452()
        {
            var expected = -.38;
            var utility = new Utility();
            var actual = utility.GetSine(452);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsPoint75For1025()
        {
            var expected = .75;
            var utility = new Utility();
            var actual = utility.GetSine(1025);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsPoint75For7()
        {
            var expected = .75;
            var utility = new Utility();
            var actual = utility.GetCosine(7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsNegativePoint91For9()
        {
            var expected = -.91;
            var utility = new Utility();
            var actual = utility.GetCosine(9);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsPoint53For45()
        {
            var expected = .53;
            var utility = new Utility();
            var actual = utility.GetCosine(45);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsNegative3Point38For5()
        {
            var expected = -3.38;
            var utility = new Utility();
            var actual = utility.GetTangent(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsNegativePoint42For75()
        {
            var expected = -.42;
            var utility = new Utility();
            var actual = utility.GetTangent(75);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2Point35ForNegativeOneThousandOne()
        {
            var expected = 2.35;
            var utility = new Utility();
            var actual = utility.GetTangent(-1001);

            Assert.AreEqual(expected, actual);
        }
    }
}
