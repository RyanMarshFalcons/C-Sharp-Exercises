using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concatenate_Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concatenate_Strings_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsRyanisacoolguy()
        {
            var expected = "Ryan is a cool guy";

            var utility = new Utility();
            var actual = utility.ConcatenateStrings("Ryan is a", " cool guy");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTakethedogforawalk()
        {
            var expected = "Take the dog for a walk";

            var utility = new Utility();
            var actual = utility.ConcatenateStrings("Take the dog ", "for a walk");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returnssuperman()
        {
            var expected = "Superman";

            var utility = new Utility();
            var actual = utility.ConcatenateStrings("Super", "man");

            Assert.AreEqual(expected, actual);
        }
    }
}
    
    

