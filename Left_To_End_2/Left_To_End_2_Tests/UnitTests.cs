using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Left_To_End_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Left_To_End_2_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForan()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("an");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForant()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("ant");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForants()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("ants");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsnnerRuForRunner()
        {
            var expected = "nnerRu";

            var utility = new Utility();
            var actual = utility.CreateNewString("Runner");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsringtimespForspringtime()
        {
            var expected = "ring timesp";

            var utility = new Utility();
            var actual = utility.CreateNewString("spring time");

            Assert.AreEqual(expected, actual);
        }
    }
}
