using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Number_Sorter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberSorterTesting
{
    [TestClass]
    public class UnitTesting
    {
        [TestMethod]
        public void ReturnsFalseforA()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor5point2()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("5.2");

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
        public void ReturnsFalseForj()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("j");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2point14point26point38point410point5()
        {
            var expectedList = new List<double>() { 2.1, 4.2, 6.3, 8.4, 10.5 };
            

            var utility = new Utility();
            var actualList = new List<double>() { 6.3, 10.5, 2.1, 8.4, 4.2 };
            actualList = utility.SortTheNumbers(actualList);

            CollectionAssert.AreEqual(expectedList, actualList);
        }

        [TestMethod]
        public void Returns5point710point415point120point725point230point7()
        {
            var expectedList = new List<double>() { 5.7, 10.4, 15.1, 20.7, 25.2, 30.7 };


            var utility = new Utility();
            var actualList = new List<double>() { 15.1, 25.2, 5.7, 30.7, 10.4, 20.7 };
            actualList = utility.SortTheNumbers(actualList);

            CollectionAssert.AreEqual(expectedList, actualList);
        }
    }
}
