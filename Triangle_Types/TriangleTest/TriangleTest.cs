using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesUtility;
using Startup;

namespace ShapeUtility.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void JIsNotAnInt()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("J");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NineIsAnInt()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("9");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NegativeOneIsNotPositive()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("-1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZeroIsNotPositive()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneIsPositive()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoIsPositive()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("2");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InvalidTriangleCalculatedProperly()
        {
            var expected = TriangleType.Invalid;

            var utility = new Utility();
            var actual = utility.typeOfTriangle(7, 5, 75);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EquilateralTriangleCalculatedProperly()
        {
            var expected = TriangleType.Equilateral;

            var utility = new Utility();
            var actual = utility.typeOfTriangle(5, 5, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsoscelesTriangleCalculatedProperly()
        {
            var expected = TriangleType.Isosceles;

            var utility = new Utility();
            var actual = utility.typeOfTriangle(5, 5, 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScaleneTriangleCalculatedProperly()
        {
            var expected = TriangleType.Scalene;

            var utility = new Utility();
            var actual = utility.typeOfTriangle(5, 6, 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EquilateralEdgeCase()
        {
            var expected = TriangleType.Equilateral;

            var utility = new Utility();
            var actual = utility.typeOfTriangle(2147483647, 2147483647, 2147483647);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsoscelesEdgeCase()
        {
            var expected = TriangleType.Isosceles;

            var utility = new Utility();
            var actual = utility.typeOfTriangle(2147483647, 2147483647, 2147483646);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScaleneEdgeCase()
        {
            var expected = TriangleType.Scalene;

            var utility = new Utility();
            var actual = utility.typeOfTriangle(2147483647, 2147483646, 2147483645);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SidesOf7And5And75AreInvalid()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.InvalidTraingle(7, 5, 75);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SidesOf7And7And7AreEquilateral()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.Equilateral(7, 7, 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SidesOf7And7And5AreIsosceles()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.Isosceles(7, 7, 5);

            Assert.AreEqual(expected, actual);
        }
    }
}
