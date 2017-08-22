using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temperature_Conversions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Temperature_Conversions_Tests
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
        public void ReturnsFalseForConnecticut()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Connecticut");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor14point295()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("14.295");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns64point4For18()
        {
            var expected = 64.4;

            var utility = new Utility();
            var actual = utility.GetFahrenheit(18);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns209point97For98point872()
        {
            var expected = 209.97;

            var utility = new Utility();
            var actual = utility.GetFahrenheit(98.872);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns32point22For90()
        {
            var expected = 32.22;

            var utility = new Utility();
            var actual = utility.GetCelsius(90);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns73point75For164point741()
        {
            var expected = 73.75;

            var utility = new Utility();
            var actual = utility.GetCelsius(164.741);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns55point56For100()
        {
            var expected = 55.56;

            var utility = new Utility();
            var actual = utility.GetKelvin(100);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns21point18For38point125()
        {
            var expected = 21.18;

            var utility = new Utility();
            var actual = utility.GetKelvin(38.125);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns180For100()
        {
            var expected = 180;

            var utility = new Utility();
            var actual = utility.GetRankine(100);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns53point02For29point456()
        {
            var expected = 53.02;

            var utility = new Utility();
            var actual = utility.GetRankine(29.456);

            Assert.AreEqual(expected, actual);
        }
    }
}
