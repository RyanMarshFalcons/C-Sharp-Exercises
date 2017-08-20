using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Left_To_End_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Left_To_End_4_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseFormice()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("mice");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFormouse()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("mouse");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFormouses()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("mouses");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnserRunnForRunner()
        {
            var expected = "erRunn";

            var utility = new Utility();
            var actual = utility.CreateNewString("Runner");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsngtimespriForspringtime()
        {
            var expected = "ng timespri";

            var utility = new Utility();
            var actual = utility.CreateNewString("spring time");

            Assert.AreEqual(expected, actual);
        }
    }
}
