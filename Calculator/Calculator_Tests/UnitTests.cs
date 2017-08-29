using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForC()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative3point14()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("-3.14");

            Assert.AreEqual(expected, actual);
        }

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
        public void ReturnsTrueForE()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForF()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForG()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForH()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("H");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForI()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("I");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForJ()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("J");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForK()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("K");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForL()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("L");

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Returns9For4Plus5()
        {
            var expected = 9;

            var utility = new Utility();
            var actual = utility.GetSum(4, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsNegative1For4Minus5()
        {
            var expected = -1;

            var utility = new Utility();
            var actual = utility.GetDifference(4, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns20For4Times5()
        {
            var expected = 20;

            var utility = new Utility();
            var actual = utility.GetProduct(4, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0Point8For4DividedBy5()
        {
            var expected = 0.8;

            var utility = new Utility();
            var actual = utility.GetQuotient(4, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns64ForNegative8()
        {
            var expected = 64;

            var utilty = new Utility();
            var actual = utilty.GetNumberSquared(-8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns25For5()
        {
            var expected = 25;

            var utilty = new Utility();
            var actual = utilty.GetNumberSquared(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns81For9()
        {
            var expected = 81;

            var utilty = new Utility();
            var actual = utilty.GetNumberSquared(9);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsNegative8ForNegative2()
        {
            var expected = -8;

            var utility = new Utility();
            var actual = utility.GetNumberCubed(-2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns125For5()
        {
            var expected = 125;

            var utility = new Utility();
            var actual = utility.GetNumberCubed(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns64For4()
        {
            var expected = 64;

            var utility = new Utility();
            var actual = utility.GetNumberCubed(4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns16ForNegative2()
        {
            var expected = 16;

            var utility = new Utility();
            var actual = utility.GetNumberTesseracted(-2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns625For5()
        {
            var expected = 625;

            var utility = new Utility();
            var actual = utility.GetNumberTesseracted(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns256For4()
        {
            var expected = 256;

            var utility = new Utility();
            var actual = utility.GetNumberTesseracted(4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns10For100()
        {
            var expected = 10;

            var utility = new Utility();
            var actual = utility.GetSquareRoot(100);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3point4For11point56()
        {
            var expected = 3.4;

            var utility = new Utility();
            var actual = utility.GetSquareRoot(11.56);

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
