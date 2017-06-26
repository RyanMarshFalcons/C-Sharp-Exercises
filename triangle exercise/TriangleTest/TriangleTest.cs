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
        public void EquilateralCalculatedProperly()
        {
            TriangleType ExpectedType = TriangleType.Equilateral;
            var testTriangle = new Triangle();

            TriangleType ActualType = testTriangle.typeOfTriangle(5, 5, 5);

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void IsoscelesCalculatedProperly()
        {
            TriangleType ExpectedType = TriangleType.Isosceles;
            var testTriangle = new Triangle();

            TriangleType ActualType = testTriangle.typeOfTriangle(5, 5, 7);

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void ScaleneCalculatedProperly()
        {
            TriangleType ExpectedType = TriangleType.Scalene;
            var testTriangle = new Triangle();

            TriangleType ActualType = testTriangle.typeOfTriangle(5, 6, 7);

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TriangleInequalityError()
        {
            var testTriangle = new Triangle();

            TriangleType ActualType = testTriangle.typeOfTriangle(5, 6, 77);
        }

        [TestMethod]
        public void EquilateralEdgeCase()
        {
            TriangleType ExpectedType = TriangleType.Equilateral;
            var testTriangle = new Triangle();

            TriangleType ActualType = testTriangle.typeOfTriangle(2147483647, 2147483647, 2147483647);

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void IsoscelesEdgeCase()
        {
            TriangleType ExpectedType = TriangleType.Isosceles;
            var testTriangle = new Triangle();

            TriangleType ActualType = testTriangle.typeOfTriangle(2147483647, 2147483647, 2147483646);

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void ScaleneEdgeCase()
        {
            TriangleType ExpectedType = TriangleType.Scalene;
            var testTriangle = new Triangle();

            TriangleType ActualType = testTriangle.typeOfTriangle(2147483647, 2147483646, 2147483645);

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeBoundaryCase()
        {
            var testTriangle = new Triangle();

            TriangleType ActualType = testTriangle.typeOfTriangle(-1, 5, 5);
        }
    }
}
