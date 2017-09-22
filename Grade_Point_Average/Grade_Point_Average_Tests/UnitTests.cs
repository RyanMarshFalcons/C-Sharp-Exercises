using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grade_Point_Average;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grade_Point_Average_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void AIsAValidGrade()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGrade("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AMinusIsAValidGrade()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGrade("A-");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BPlusIsAValidGrade()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGrade("B+");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BIsAValidGrade()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGrade("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BMinusIsAValidGrade()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGrade("B-");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CPlusIsAValidGrade()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGrade("C+");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CIsAValidGrade()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGrade("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CMinusIsAValidGrade()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGrade("C-");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DPlusIsAValidGrade()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGrade("D+");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DIsAValidGrade()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGrade("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DMinusIsAValidGrade()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGrade("D-");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FIsAValidGrade()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGrade("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GIsNotAValidGrade()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidGrade("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2point9ForBplusBCplusAminusAminusCCplus()
        {
            var expected = 2.9;

            var utility = new Utility();
            var actual = utility.CalculateGPA(new Dictionary<string, string>() { { "English", "B+" }, { "World History", "B" }, { "Algebra", "C+" }, { "Physical Science", "A-" }, { "French", "A-" }, { "Health", "C" }, { "Art", "C+" } });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3point6ForAAminusAminusBplusBplusBA()
        {
            var expected = 3.6;

            var utility = new Utility();
            var actual = utility.CalculateGPA(new Dictionary<string, string>() { { "English", "A" }, { "World History", "A-" }, { "Algebra", "A-" }, { "Physical Science", "B+" }, { "French", "B+" }, { "Health", "B" }, { "Art", "A" } });

            Assert.AreEqual(expected, actual);
        }
    }
}
