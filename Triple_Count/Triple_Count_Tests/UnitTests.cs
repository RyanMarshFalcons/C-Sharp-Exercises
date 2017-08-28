using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triple_Count;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Triple_Count_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForhi()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("hi");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForhim()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("him");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns6Forabbcccddddeeeee()
        {
            var expected = 6;

            var utility = new Utility();
            var actual = utility.CountTriples("abbcccddddeeeee");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2ForAaaBbbCCCdddEee()
        {
            var expected = 2;

            var utility = new Utility();
            var actual = utility.CountTriples("AaaBbbCCCdddEee");

            Assert.AreEqual(expected, actual);
        }
    }
}
