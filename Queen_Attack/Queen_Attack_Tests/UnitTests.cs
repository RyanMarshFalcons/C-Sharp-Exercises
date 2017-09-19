using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queen_Attack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Queen_Attack_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void LIsNotAnInt()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("L");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ThirteenIsAnInt()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("13");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NegativeOneIsNotPositive()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("-1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZeroIsNotPositive()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneIsPositive()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoIsPositive()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("2");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NineIsTooHigh()
        {
            var expected = true;
            
            var utility = new Utility();
            var actual = utility.CheckIfTooHigh("9");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EightIsNotTooHigh()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooHigh("8");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AllowsTwoQueensNotInSamePosition()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.AreSamePosition(new Queen { Row = 5, Column = 6 }, new Queen { Row = 6, Column = 5 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CatchesTwoQueensInSamePosition()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.AreSamePosition(new Queen { Row = 5, Column = 6 }, new Queen { Row = 5, Column = 6 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoQueensInSameRow()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.AreSameRow(new Queen { Row = 3, Column = 7 }, new Queen { Row = 3, Column = 5 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoQueensInDifferentRows()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.AreSameRow(new Queen { Row = 3, Column = 7 }, new Queen { Row = 4, Column = 5 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoQueensInSameColumn()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.AreSameColumn(new Queen { Row = 3, Column = 7 }, new Queen { Row = 4, Column = 7 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoQueensInDifferentColumns()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.AreSameColumn(new Queen { Row = 3, Column = 7 }, new Queen { Row = 4, Column = 8 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoQueensInSameDiagonal()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.AreSameDiagonal(new Queen { Row = 3, Column = 4 }, new Queen { Row = 5, Column = 6 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoQueensInDifferentDiagonals()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.AreSameDiagonal(new Queen { Row = 3, Column = 4 }, new Queen { Row = 5, Column = 7 });

            Assert.AreEqual(expected, actual);
        }
    }
}
