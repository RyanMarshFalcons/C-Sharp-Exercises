using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseracted;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tesseracted_Tests
{
    [TestClass]
    public class UnitTesting
    {
        [TestMethod]
        public void ReturnsTrueFor11()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("11");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForI()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("I");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns16ForNegative2()
        {
            var expected = 16;

            var utility = new Utility();
            var actual = utility.GetNumberTesseracted(-2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns625For5()
        {
            var expected = 625;

            var utility = new Utility();
            var actual = utility.GetNumberTesseracted(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns256For4()
        {
            var expected = 256;

            var utility = new Utility();
            var actual = utility.GetNumberTesseracted(4);

            Assert.AreEqual(expected, actual);
        }
    }
}
