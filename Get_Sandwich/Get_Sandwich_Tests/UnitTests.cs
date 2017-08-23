using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Get_Sandwich;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Get_Sandwich_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForRyanMarsh()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("Ryan Marsh");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForRyanMarshExclamationPoint()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("Ryan Marsh!");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0Forbreadwinner()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.GetIndexOfFirstSlice("breadwinner");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0ForCharlieisthebreadwinner()
        {
            var expected = 12;

            var utility = new Utility();
            var actual = utility.GetIndexOfFirstSlice("charlieisthebreadwinner");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0AgainForbreadwinner()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.GetIndexOfSecondSlice("breadwinner");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns23ForCharlieisthebreadwinnerbreadwinner()
        {
            var expected = 23;

            var utility = new Utility();
            var actual = utility.GetIndexOfSecondSlice("Charlieisthebreadwinnerbreadwinner");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns29Forbreadcheesebreadmeatbreadmayobread()
        {
            var expected = 29;

            var utility = new Utility();
            var actual = utility.GetIndexOfSecondSlice("breadcheesebreadmeatbreadmayobread");

            Assert.AreEqual(expected, actual);
        }
    }
}
