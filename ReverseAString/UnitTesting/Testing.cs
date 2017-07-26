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
        public void returnsNAYR()
        {
            var expected = "NAYR";

            var manipulation = new Manipulation();
            var actual = manipulation.inputInReverse("RYAN");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returns987654321cba()
        {
            var expected = "9 8 7 6 5 4 3 2 1 c b a";

            var manipulation = new Manipulation();
            var actual = manipulation.inputInReverse("a b c 1 2 3 4 5 6 7 8 9");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnssemitfotsrowehtsawtIsemitfotsebehtsawtI()
        {
            var expected = ".semit fo tsrow eht saw tI .semit fo tseb eht saw tI";

            var manipulation = new Manipulation();
            var actual = manipulation.inputInReverse("It was the best of times. It was the worst of times.");

            Assert.AreEqual(expected, actual);
        }
         


    }
}
