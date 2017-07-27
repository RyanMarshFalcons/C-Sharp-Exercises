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
        public void returnsFalseforA()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsTrueFor5()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("5");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsTrueFory()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("y");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsTrueForn()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("n");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsFalseForj()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("j");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returns246810()
        {
            var expectedList = new List<int>() { 2, 4, 6, 8, 10 };
            

            var utility = new Utility();
            var actualList = new List<int>() { 6, 10, 2, 8, 4 };
            actualList = utility.SortTheNumbers(actualList);

            CollectionAssert.AreEqual(expectedList, actualList);
        }

        [TestMethod]
        public void returns51015202530()
        {
            var expectedList = new List<int>() { 5, 10, 15, 20, 25, 30 };


            var utility = new Utility();
            var actualList = new List<int>() { 15, 25, 5, 30, 10, 20 };
            actualList = utility.SortTheNumbers(actualList);

            CollectionAssert.AreEqual(expectedList, actualList);
        }
    }
}
