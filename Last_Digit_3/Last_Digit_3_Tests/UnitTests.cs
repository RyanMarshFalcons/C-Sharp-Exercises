using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Last_Digit_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Last_Digit_3_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor15()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("15");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForb()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("b");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative37()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-37");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor37()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("37");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns258For123548()
        {
            var expected = new int[] { 2, 5, 8 };

            var utility = new Utility();
            var actual = utility.LastDigits(new int[] { 12, 35, 48 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns68For901615178()
        {
            var expected = new int[] { 6, 8, 9 };

            var utility = new Utility();
            var actual = utility.LastDigits(new int[] { 9016, 15178, 243589 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2For2()
        {
            var expected = 2;

            var utility = new Utility();
            var actual = utility.GetLastDigit(2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns6For36()
        {
            var expected = 6;

            var utility = new Utility();
            var actual = utility.GetLastDigit(36);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns7For677()
        {
            var expected = 7;

            var utility = new Utility();
            var actual = utility.GetLastDigit(677);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2For812()
        {
            var expected = 2;

            var utility = new Utility();
            var actual = utility.GetLastDigit(812);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor336()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckForMatch(new int[] { 3, 3, 6 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor122()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckForMatch(new int[] { 1, 2, 2 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor888()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckForMatch(new int[] { 8, 8, 8 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor815()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckForMatch(new int[] { 8, 1, 5 });

            Assert.AreEqual(expected, actual);
        }
    }
}
