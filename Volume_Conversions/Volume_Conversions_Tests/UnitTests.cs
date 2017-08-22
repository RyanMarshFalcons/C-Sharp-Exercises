using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volume_Conversions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Volume_Conversions_Tests
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
        public void ReturnsFalseForGeorgia()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Georgia");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor12point295()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("12.295");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative16point83()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-16.83");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor16point83()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("16.83");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns22point71For6()
        {
            var expected = 22.71;

            var utility = new Utility();
            var actual = utility.GetLiters(6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns353point02For93point258()
        {
            var expected = 353.02;

            var utility = new Utility();
            var actual = utility.GetLiters(93.258);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0point79For3()
        {
            var expected = 0.79;

            var utility = new Utility();
            var actual = utility.GetGallons(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns7point12For27point128()
        {
            var expected = 7.17;

            var utility = new Utility();
            var actual = utility.GetGallons(27.128);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3point45For17()
        {
            var expected = 3.45;

            var utility = new Utility();
            var actual = utility.GetTeaspoons(17);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns12point83For63point249()
        {
            var expected = 12.83;

            var utility = new Utility();
            var actual = utility.GetTeaspoons(63.249);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns118point29For24()
        {
            var expected = 118.29;

            var utility = new Utility();
            var actual = utility.GetMilliliters(24);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns372point61For75point5974()
        {
            var expected = 372.61;

            var utility = new Utility();
            var actual = utility.GetMilliliters(75.5974);

            Assert.AreEqual(expected, actual);
        }
    }
}
