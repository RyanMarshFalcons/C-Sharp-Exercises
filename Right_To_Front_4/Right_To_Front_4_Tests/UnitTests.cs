using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Right_To_Front_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Right_To_Front_4_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForbook()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("book");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForbooks()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("books");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForbooksy()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("booksy");

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
        public void ReturnstimespringForspringtime()
        {
            var expected = "timespring ";

            var utility = new Utility();
            var actual = utility.CreateNewString("spring time");

            Assert.AreEqual(expected, actual);
        }
    }
}
