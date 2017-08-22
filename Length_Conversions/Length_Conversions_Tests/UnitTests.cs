using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Length_Conversions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Length_Conversions_Tests
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
        public void ReturnsFalseForMaine()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Maine");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor12point286()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("12.286");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative16point24()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-16.24");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor16point24()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("16.24");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns5point49For18()
        {
            var expected = 5.49;

            var utility = new Utility();
            var actual = utility.GetMeters(18);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns24point03For78point8543()
        {
            var expected = 24.03;

            var utility = new Utility();
            var actual = utility.GetMeters(78.8543);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns22point97For7()
        {
            var expected = 22.97;

            var utility = new Utility();
            var actual = utility.GetFeet(7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns967point41For294point8651()
        {
            var expected = 967.41;

            var utility = new Utility();
            var actual = utility.GetFeet(294.8651);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3point01For4point85()
        {
            var expected = 3.01;

            var utility = new Utility();
            var actual = utility.GetMiles(4.85);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns54point53For87point7253()
        {
            var expected = 54.53;

            var utility = new Utility();
            var actual = utility.GetMiles(87.7523);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns8point05For5()
        {
            var expected = 8.05;

            var utility = new Utility();
            var actual = utility.GetKilometers(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns150point65For93point612()
        {
            var expected = 150.65;

            var utility = new Utility();
            var actual = utility.GetKilometers(93.612);

            Assert.AreEqual(expected, actual);
        }
    }
}
