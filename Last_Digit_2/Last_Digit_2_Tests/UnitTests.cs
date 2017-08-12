using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Last_Digit_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Last_Digit_2_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor17()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("17");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFora()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("a");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative28()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-28");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor28()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("28");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns25For1235()
        {
            var expected = new int[] { 2, 5 };

            var utility = new Utility();
            var actual = utility.LastDigits(new int[] { 12, 35 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns68For901615178()
        {
            var expected = new int[] { 6, 8 };

            var utility = new Utility();
            var actual = utility.LastDigits(new int[] { 9016, 15178 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns7For7()
        {
            var expected = 7;

            var utility = new Utility();
            var actual = utility.GetLastDigit(7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4For34()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.GetLastDigit(34);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns9For679()
        {
            var expected = 9;

            var utility = new Utility();
            var actual = utility.GetLastDigit(679);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2For8002()
        {
            var expected = 2;

            var utility = new Utility();
            var actual = utility.GetLastDigit(8002);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor33()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckForMatch(new int[] { 3, 3 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor00()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckForMatch(new int[] { 0, 0 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor88()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckForMatch(new int[] { 8, 8 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor83()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckForMatch(new int[] { 8, 3 });

            Assert.AreEqual(expected, actual);
        }
    }
}
