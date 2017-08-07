using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gradebook;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gradebook_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseforK()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("K");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor4point322()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("4.322");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor68point7()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfWithinRange("68.7");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative1()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfWithinRange("-1");

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

        [TestMethod]
        public void Returns80point4()
        {
            var expected = 80.4;

            var utility = new Utility();
            var actual = utility.GetFinalGrade(new List<double>() { 75, 83, 97, 65, 72, 81, 90 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns90point8()
        {
            var expected = 90.8;

            var utility = new Utility();
            var actual = utility.GetFinalGrade(new List<double>() { 94.3, 81.7, 88.5, 97.2, 99.8, 84.2, 89.7 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsAplus()
        {
            var expected = "A+";

            var utility = new Utility();
            var actual = utility.GetLetterGrade(98.7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsF()
        {
            var expected = "F";

            var utility = new Utility();
            var actual = utility.GetLetterGrade(56.2);

            Assert.AreEqual(expected, actual);
        }
    }
}
