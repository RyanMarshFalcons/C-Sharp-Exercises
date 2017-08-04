using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToLowerCase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ToLowerCase_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void returnsinrediblethings()
        {
            var expected = "incredible things";

            var utility = new Utility();
            var actual = utility.ToLowerCase("IncRedible tHIngS");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsthemanwithoneredshoe()
        {
            var expected = "the man with one red shoe";

            var utility = new Utility();
            var actual = utility.ToLowerCase("The mAn wiTh one rED sHoe");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnscomeasyouare()
        {
            var expected = "come as you are";

            var utility = new Utility();
            var actual = utility.ToLowerCase("COme As YOu aRe");

            Assert.AreEqual(expected, actual);
        }
    }
}
