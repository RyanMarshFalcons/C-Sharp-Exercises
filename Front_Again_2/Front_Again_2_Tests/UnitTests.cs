using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Front_Again_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Front_Again_2_Tests
{
    public class UnitTests
    {
        [TestClass]
        public class Testing
        {
            [TestMethod]
            public void ReturnsFalseFormet()
            {
                var expected = false;

                var utility = new Utility();
                var actual = utility.CheckIfLongEnough("met");

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void ReturnsTrueFormeet()
            {
                var expected = true;

                var utility = new Utility();
                var actual = utility.CheckIfLongEnough("meet");

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void ReturnsRyForRyan()
            {
                var expected = "Ry";

                var utility = new Utility();
                var actual = utility.GetBegining("Ryan");

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void ReturnsCaForCalifornia()
            {
                var expected = "Ca";

                var utility = new Utility();
                var actual = utility.GetBegining("California");

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void ReturnsanForRyan()
            {
                var expected = "an";

                var utility = new Utility();
                var actual = utility.GetEnding("Ryan");

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void ReturnsiaForCalifornia()
            {
                var expected = "ia";

                var utility = new Utility();
                var actual = utility.GetEnding("California");

                Assert.AreEqual(expected, actual);
            }
        }
    }
}
