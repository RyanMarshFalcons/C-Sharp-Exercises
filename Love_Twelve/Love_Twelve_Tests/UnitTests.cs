using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Love_Twelve;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Love_Twelve_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor27()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("27");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForx()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("x");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor12()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTwelve(12, 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNo12s()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTwelve(7, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor4and8()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfSumIsTwelve(4, 8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor4and9()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfSumIsTwelve(4, 9);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor13and1()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDifferenceIsTwelve(13, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor13and2()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDifferenceIsTwelve(13, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor3and4()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfProductIsTwelve(3, 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor3and5()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfProductIsTwelve(3, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor24and2()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfQuotientIsTwelve(24, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor24and3()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfQuotientIsTwelve(24, 3);

            Assert.AreEqual(expected, actual);
        }
    }
}
