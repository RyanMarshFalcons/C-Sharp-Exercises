using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StartUp;
using BlackJack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackJack_Tests
{
    [TestClass]
    class Tests
    {
       [TestMethod]
       public void ReturnsFalseIfBetIsBelowMinimum()
       {
            var expectedResult = false;

            var bet = new Bet();
            var actualResult = bet.IsBetMakable(3.00, 150.00);

            Assert.AreEqual(expectedResult, actualResult);
       }





    }
}
