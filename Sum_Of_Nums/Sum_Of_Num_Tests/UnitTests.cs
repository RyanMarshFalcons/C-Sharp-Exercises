using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sum_Of_Nums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sum_Of_Num_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseforL()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("L");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor6point7()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("6.7");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFory()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("y");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForn()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("n");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForx()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("x");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns16point5For1point12point23point34point45point5()
        {
            var expected = 16.5;

            var utility = new Utility();
            var actual = utility.SumTheNumbers(new List<double>() { 1.1, 2.2, 3.3, 4.4, 5.5 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns212point6For81point236point894point6()
        {
            var expected = 212.6;

            var utility = new Utility();
            var actual = utility.SumTheNumbers(new List<double>() { 81.2, 36.8, 94.6 });

            Assert.AreEqual(expected, actual);
        }
    }
}
