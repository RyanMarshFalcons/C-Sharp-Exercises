using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electoral_College;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Electoral_College_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsCorrectDictionary()
        {
            var expected = new Dictionary<string, int>()
                {
                    { "Alabama", 9 },
                    { "Alaska", 3 },
                    { "Arizona", 11 },
                    { "Arkansas", 6 },
                    { "California", 55 },
                    { "Colorado", 9 },
                    { "Connecticut", 7 },
                    { "Delaware", 3 },
                    { "District of Columbia", 3},
                    { "Florida", 29 },
                    { "Georgia", 16 },
                    { "Hawaii", 4 },
                    { "Idaho", 4 },
                    { "Illinois", 20 },
                    { "Indiana", 11 },
                    { "Iowa", 6 },
                    { "Kansas", 6 },
                    { "Kentucky", 8 },
                    { "Louisiana", 8 },
                    { "Maine", 4 },
                    { "Maryland", 10 },
                    { "Massachusetts", 11 },
                    { "Michigan", 16 },
                    { "Minnesota", 10 },
                    { "Mississippi", 6 },
                    { "Missouri", 10 },
                    { "Montana", 3 },
                    { "Nebraska", 5 },
                    { "Nevada", 6 },
                    { "New Hampshire", 4 },
                    { "New Jersey", 14 },
                    { "New Mexico", 5 },
                    { "New York", 29 },
                    { "North Carolina", 15 },
                    { "North Dakota", 3 },
                    { "Ohio", 18 },
                    { "Oklahoma", 7 },
                    { "Oregon", 7 },
                    { "Pennsylvania", 20 },
                    { "Rhode Island", 4 },
                    { "South Carolina", 9 },
                    { "South Dakota", 3 },
                    { "Tennessee", 11 },
                    { "Texas", 38 },
                    { "Utah", 6 },
                    { "Vermont", 3 },
                    { "Virginia", 13 },
                    { "Washington", 12 },
                    { "West Virginia", 5 },
                    { "Wisconsin", 10 },
                    { "Wyoming", 3 }
               };

            var utility = new Utility();
            var actual = utility.VotesPerState();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor1()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIf1or2("1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor2()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIf1or2("2");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor3()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIf1or2("3");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WinnerOfStateUserFor1()
        {
            var expected = WinnerOfState.User;

            var utility = new Utility();
            var actual = utility.NumSelectionToEnum(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WinnerOfStateMeFor2()
        {
            var expected = WinnerOfState.Me;

            var utility = new Utility();
            var actual = utility.NumSelectionToEnum(2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns74ForWestCoast()
        {
            var expected = 74;

            var utility = new Utility();
            var actual = utility.SumOfVotes(new List<int>() { 55, 7, 12 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns88ForSouthEast()
        {
            var expected = 88;

            var utility = new Utility();
            var actual = utility.SumOfVotes(new List<int>() { 9, 16, 29, 11, 9, 6, 8 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IReceivedMoreElectoralVotes()
        {
            var expected = ResultOfElection.IWon;

            var utility = new Utility();
            var actual = utility.DetermineResultOfElection(300, 238);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UserReceivedMoreElectoralVotes()
        {
            var expected = ResultOfElection.UserWon;

            var utility = new Utility();
            var actual = utility.DetermineResultOfElection(238, 300);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReceivedSameElectoralVotes()
        {
            var expected = ResultOfElection.Tie;

            var utility = new Utility();
            var actual = utility.DetermineResultOfElection(269, 269);

            Assert.AreEqual(expected, actual);
        }
    }
}
