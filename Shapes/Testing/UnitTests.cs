﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Startup;
using Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void AIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FIsNotAValidSelection()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ARepresentsSquare()
        {
            var expected = TypeOfShape.Square;

            var utility = new Utility();
            var actual = utility.ConvertLetterToTypeOfShape("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BRepresentsRectangle()
        {
            var expected = TypeOfShape.Rectangle;

            var utility = new Utility();
            var actual = utility.ConvertLetterToTypeOfShape("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CRepresentsTriangle()
        {
            var expected = TypeOfShape.Triangle;

            var utility = new Utility();
            var actual = utility.ConvertLetterToTypeOfShape("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DRepresentsTrapezoid()
        {
            var expected = TypeOfShape.Trapezoid;

            var utility = new Utility();
            var actual = utility.ConvertLetterToTypeOfShape("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ERepresentsCircle()
        {
            var expected = TypeOfShape.Circle;

            var utility = new Utility();
            var actual = utility.ConvertLetterToTypeOfShape("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NegativeZeroPointZeroOneIsNotPositive()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsPositive("-.01");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZeroPointZeroZeroIsNotPositive()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsPositive("0.00");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZeroPointZeroOneIsPositive()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsPositive(".01");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatesTriangleArea ()
        {
            var expectedArea = 2.04;

            var triangle = new Triangle();
            triangle.baseSide = 1.2;
            triangle.height = 3.4;
            var actualArea = triangle.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CalculatesTrianglePerimeter()
        {
            var expectedPerimeter = 9.1;

            var triangle = new Triangle();
            triangle.baseSide = 1.2;
            triangle.side2 = 3.4;
            triangle.side3 = 4.5;
            var actualPerimeter = triangle.CalculatePerimiter();

            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [TestMethod]
        public void CalculatesSquareArea()
        {
            var expectedArea = 1.44;

            var square = new Square();
            square.side = 1.2;
            var actualArea = square.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CalculatesSquarePerimeter()
        {
            var expectedPerimeter = 4.8;

            var square = new Square();
            square.side = 1.2;
            var actualPerimeter = square.CalculatePerimiter();

            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [TestMethod]
        public void CalculatesRectangleArea()
        {
            var expectedArea = 4.08;

            var rectangle = new Rectangle();
            rectangle.height = 1.2;
            rectangle.width = 3.4;
            var actualArea = rectangle.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CalculatesRectanglePerimeter()
        {
            var expectedPerimeter = 9.2;

            var rectangle = new Rectangle();
            rectangle.height = 1.2;
            rectangle.width = 3.4;
            var actualPerimeter = rectangle.CalculatePerimiter();

            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [TestMethod]
        public void CalculatesTrapezoidArea()
        {
            var expectedArea = 4.5;

            var trapezoid = new Trapezoid();
            trapezoid.base1 = 1;
            trapezoid.base2 = 2;
            trapezoid.height = 3;
            var actualArea = trapezoid.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CalculatesTrapezoidPerimeter()
        {
            var expectedPerimeter = 18;

            var trapezoid = new Trapezoid();
            trapezoid.base1 = 1.2;
            trapezoid.base2 = 3.4;
            trapezoid.leg1 = 5.6;
            trapezoid.leg2 = 7.8;

            var actualPerimeter = trapezoid.CalculatePerimiter();

            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [TestMethod]
        public void CalculatesCircleArea()
        {
            var expectedArea = 3.14;

            var circle = new Circle();
            circle.radius = 1;
           
            var actualArea = circle.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CalculatesCirclePerimeter()
        {
            var expectedPerimeter = 6.28;

            var circle = new Circle();
            circle.radius = 1;

            var actualPerimeter = circle.CalculatePerimiter();

            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }
    }
}
