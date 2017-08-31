using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Replace_Characters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Replace_Characters_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returns3ForRyan()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.GetMaxIndex("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns9Forbasketball()
        {
            var expected = 9;

            var utility = new Utility();
            var actual = utility.GetMaxIndex("basketball");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor23()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("23");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForw()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("w");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor77()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfIndexExists("7", 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor87()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfIndexExists("8", 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative17()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfIndexExists("-1", 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrainTreckForTrainwreck5T()
        {
            var expected = "TrainTreck";

            var utility = new Utility();
            var actual = utility.GetNewString("Trainwreck", 5, 'T');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRyanisacoolgoyForRyanisacoolguy17o()
        {
            var expected = "Ryan is a cool goy";

            var utility = new Utility();
            var actual = utility.GetNewString("Ryan is a cool guy", 16, 'o');

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
        public void ReturnsFalseFors()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("s");

            Assert.AreEqual(expected, actual);
        }
    }
}
