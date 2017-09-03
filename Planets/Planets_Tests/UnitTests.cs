using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Planets_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForA()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsABCDEFGH("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForB()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsABCDEFGH("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForC()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsABCDEFGH("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForD()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsABCDEFGH("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForE()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsABCDEFGH("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForF()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsABCDEFGH("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForG()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsABCDEFGH("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForH()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsABCDEFGH("H");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForI()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsABCDEFGH("I");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForAagain()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsABC("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForBagain()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsABC("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForCagain()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsABC("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForD()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsABC("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor11point23()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("11.23");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForcrayon()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("crayon");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor3point57()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("3.57");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative3point57()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("-3.57");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsMercuryForA()
        {
            var expected = Planet.Mercury;

            var utility = new Utility();
            var actual = utility.ConvertLetterToPlanet("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsVenusForB()
        {
            var expected = Planet.Venus;

            var utility = new Utility();
            var actual = utility.ConvertLetterToPlanet("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsMarsForC()
        {
            var expected = Planet.Mars;

            var utility = new Utility();
            var actual = utility.ConvertLetterToPlanet("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsJupiterForD()
        {
            var expected = Planet.Jupiter;

            var utility = new Utility();
            var actual = utility.ConvertLetterToPlanet("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsSaturnForE()
        {
            var expected = Planet.Saturn;

            var utility = new Utility();
            var actual = utility.ConvertLetterToPlanet("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsUranusForF()
        {
            var expected = Planet.Uranus;

            var utility = new Utility();
            var actual = utility.ConvertLetterToPlanet("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsNeptuneForG()
        {
            var expected = Planet.Neptune;

            var utility = new Utility();
            var actual = utility.ConvertLetterToPlanet("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsPlutoForH()
        {
            var expected = Planet.Pluto;

            var utility = new Utility();
            var actual = utility.ConvertLetterToPlanet("H");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns66point15For175()
        {
            var expected = 66.15;

            var utility = new Utility();
            var actual = utility.GetWeightOnPlanet(175, Planet.Mercury);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns34point39For13()
        {
            var expected = 34.39;

            var utility = new Utility();
            var actual = utility.GetVerticalLeapOnPlanet(13, Planet.Mercury);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns124point56For30()
        {
            var expected = 124.56;

            var utility = new Utility();
            var actual = utility.GetAgeOnPlanet(30, Planet.Mercury);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns158point72For175()
        {
            var expected = 158.72;

            var utility = new Utility();
            var actual = utility.GetWeightOnPlanet(175, Planet.Venus);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns14point33For13()
        {
            var expected = 14.33;

            var utility = new Utility();
            var actual = utility.GetVerticalLeapOnPlanet(13, Planet.Venus);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns48point75For30()
        {
            var expected = 48.75;

            var utility = new Utility();
            var actual = utility.GetAgeOnPlanet(30, Planet.Venus);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns65point97For175()
        {
            var expected = 65.97;

            var utility = new Utility();
            var actual = utility.GetWeightOnPlanet(175, Planet.Mars);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns34point48For13()
        {
            var expected = 34.48;

            var utility = new Utility();
            var actual = utility.GetVerticalLeapOnPlanet(13, Planet.Mars);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns15point93For30()
        {
            var expected = 15.93;

            var utility = new Utility();
            var actual = utility.GetAgeOnPlanet(30, Planet.Mars);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns413For175()
        {
            var expected = 413;

            var utility = new Utility();
            var actual = utility.GetWeightOnPlanet(175, Planet.Jupiter);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns5point51For13()
        {
            var expected = 5.51;

            var utility = new Utility();
            var actual = utility.GetVerticalLeapOnPlanet(13, Planet.Jupiter);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2point53For30()
        {
            var expected = 2.53;

            var utility = new Utility();
            var actual = utility.GetAgeOnPlanet(30, Planet.Jupiter);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns160point3For175()
        {
            var expected = 160.3;

            var utility = new Utility();
            var actual = utility.GetWeightOnPlanet(175, Planet.Saturn);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns14point19For13()
        {
            var expected = 14.19;

            var utility = new Utility();
            var actual = utility.GetVerticalLeapOnPlanet(13, Planet.Saturn);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1point02For30()
        {
            var expected = 1.02;

            var utility = new Utility();
            var actual = utility.GetAgeOnPlanet(30, Planet.Saturn);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns155point57For175()
        {
            var expected = 155.57;

            var utility = new Utility();
            var actual = utility.GetWeightOnPlanet(175, Planet.Uranus);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns14point62For13()
        {
            var expected = 14.62;

            var utility = new Utility();
            var actual = utility.GetVerticalLeapOnPlanet(13, Planet.Uranus);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0point36For30()
        {
            var expected = 0.36;

            var utility = new Utility();
            var actual = utility.GetAgeOnPlanet(30, Planet.Uranus);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns196For175()
        {
            var expected = 196;

            var utility = new Utility();
            var actual = utility.GetWeightOnPlanet(175, Planet.Neptune);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns11point61For13()
        {
            var expected = 11.61;

            var utility = new Utility();
            var actual = utility.GetVerticalLeapOnPlanet(13, Planet.Neptune);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0point18For30()
        {
            var expected = 0.18;

            var utility = new Utility();
            var actual = utility.GetAgeOnPlanet(30, Planet.Neptune);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns12point42For175()
        {
            var expected = 12.42;

            var utility = new Utility();
            var actual = utility.GetWeightOnPlanet(175, Planet.Pluto);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns183point1For13()
        {
            var expected = 183.1;

            var utility = new Utility();
            var actual = utility.GetVerticalLeapOnPlanet(13, Planet.Pluto);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0point12For30()
        {
            var expected = 0.12;

            var utility = new Utility();
            var actual = utility.GetAgeOnPlanet(30, Planet.Pluto);

            Assert.AreEqual(expected, actual);
        }
    }
}
