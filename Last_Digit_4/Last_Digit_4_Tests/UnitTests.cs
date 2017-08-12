using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Last_Digit_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Last_Digit_4_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor9()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("9");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForg()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("g");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative98()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-98");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor98()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("98");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2587For12354857()
        {
            var expected = new int[] { 2, 5, 8, 7 };

            var utility = new Utility();
            var actual = utility.LastDigits(new int[] { 12, 35, 48, 57});

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns68For901615178345852()
        {
            var expected = new int[] { 6, 8, 9, 2 };

            var utility = new Utility();
            var actual = utility.LastDigits(new int[] { 9016, 15178, 243589, 345852 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4For4()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.GetLastDigit(4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns7For37()
        {
            var expected = 7;

            var utility = new Utility();
            var actual = utility.GetLastDigit(37);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1For671()
        {
            var expected = 1;

            var utility = new Utility();
            var actual = utility.GetLastDigit(671);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2For813()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.GetLastDigit(813);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor3361()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckForMatch(new int[] { 3, 3, 6, 1 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor1222()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckForMatch(new int[] { 1, 2, 2, 2 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor8888()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckForMatch(new int[] { 8, 8, 8, 8 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor8153()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckForMatch(new int[] { 8, 1, 5, 3 });

            Assert.AreEqual(expected, actual);
        }
    }
}
