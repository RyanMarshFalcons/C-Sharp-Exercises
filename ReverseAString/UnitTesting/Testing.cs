using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReverseAString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        public void ReturnsNAYR()
        {
            var expected = "NAYR";

            var utility = new Utility();
            var actual = utility.inputInReverse("RYAN");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns987654321cba()
        {
            var expected = "9 8 7 6 5 4 3 2 1 c b a";

            var utility = new Utility();
            var actual = utility.inputInReverse("a b c 1 2 3 4 5 6 7 8 9");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnssemitfotsrowehtsawtIsemitfotsebehtsawtI()
        {
            var expected = ".semit fo tsrow eht saw tI .semit fo tseb eht saw tI";

            var utility = new Utility();
            var actual = utility.inputInReverse("It was the best of times. It was the worst of times.");

            Assert.AreEqual(expected, actual);
        }
    }
}
