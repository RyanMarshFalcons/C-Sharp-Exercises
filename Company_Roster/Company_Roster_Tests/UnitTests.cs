using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company_Roster;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Company_Roster_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForA()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidPersonSelection("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForB()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidPersonSelection("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForC()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidPersonSelection("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFory()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("y");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForn()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("n");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForp()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("p");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsCustomerForA()
        {
            var expected = TypeOfPerson.Customer;

            var utility = new Utility();
            var actual = utility.ConvertLetterToPersonType("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsEmployeeForB()
        {
            var expected = TypeOfPerson.Employee;

            var utility = new Utility();
            var actual = utility.ConvertLetterToPersonType("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNameIsEmptyString()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.NameIsTooShort("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNameIsM()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.NameIsTooShort("M");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForPrefixSelectedA()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsValidPrefixSelection("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForPrefixSelectedB()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsValidPrefixSelection("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForPrefixSelectedC()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsValidPrefixSelection("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForPrefixSelectedD()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsValidPrefixSelection("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForPrefixSelectedE()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsValidPrefixSelection("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsMrForA()
        {
            var expected = Prefix.Mr;

            var utility = new Utility();
            var actual = utility.ConvertLetterToPrefix("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsMrsForB()
        {
            var expected = Prefix.Mrs;

            var utility = new Utility();
            var actual = utility.ConvertLetterToPrefix("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsMsForC()
        {
            var expected = Prefix.Ms;

            var utility = new Utility();
            var actual = utility.ConvertLetterToPrefix("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsMissForD()
        {
            var expected = Prefix.Miss;

            var utility = new Utility();
            var actual = utility.ConvertLetterToPrefix("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForBobcom()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.EmailIsTooShort("Bobcom");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForBobAthotmailDotcom()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.EmailIsTooShort("Bob@hotmail.com");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForRyanAthotmailcom()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.ContainsAtAndDot("Ryan@hotmailcom");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForRyanhotmailDotcom()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.ContainsAtAndDot("Ryanhotmail.com");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForRyanAthotmailDotcom()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.ContainsAtAndDot("Ryan@hotmail.com");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor432BerryLane()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.AdressIsTooShort("432 Berry Lane");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor432BerryLaneBeverlyHillsCA90210()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.AdressIsTooShort("432 Berry Lane Beverly Hills, CA 90210");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForTreeTopRoadSouthHampton()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.HasNumbers("Tree Top Road South Hampton");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor8625TreeTopRoadSouthHampton30581()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.HasNumbers("8625 Tree Top Road South Hampton 30581");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor847123456()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.PhoneNumberIsTooShort("847123456");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor8471234567()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.PhoneNumberIsTooShort("8471234567");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor5551212121Q()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.HasLetters("5551212121Q");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor5551212121()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.HasLetters("5551212121");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor123Dash456Dash789Dash5555()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfOnlyNums("123-456-789-5555");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor1234567895555()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfOnlyNums("1234567895555");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor456321478945()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidCreditCardLength("456321478945");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor4563214789457()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidCreditCardLength("4563214789457");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForCoo()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.JobTitleIsTooShort("Coo");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForCook()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.JobTitleIsTooShort("Cook");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForDepartmentA()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsValidDepartmentSelection("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForDepartmentB()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsValidDepartmentSelection("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForDepartmentC()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsValidDepartmentSelection("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForDepartmentD()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsValidDepartmentSelection("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForDepartmentE()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsValidDepartmentSelection("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForDepartmentF()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsValidDepartmentSelection("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForDepartmentG()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsValidDepartmentSelection("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForDepartmentH()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsValidDepartmentSelection("H");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsAccountingForDepartmentA()
        {
            var expected = Department.Accounting;

            var utility = new Utility();
            var actual = utility.ConvertLetterToDepartment("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsITForDepartmentB()
        {
            var expected = Department.IT;

            var utility = new Utility();
            var actual = utility.ConvertLetterToDepartment("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsSalesForDepartmentC()
        {
            var expected = Department.Sales;

            var utility = new Utility();
            var actual = utility.ConvertLetterToDepartment("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsHumanResourcesForDepartmentD()
        {
            var expected = Department.Human_Resources;

            var utility = new Utility();
            var actual = utility.ConvertLetterToDepartment("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsCustomerServiceForDepartmentE()
        {
            var expected = Department.Customer_Service;

            var utility = new Utility();
            var actual = utility.ConvertLetterToDepartment("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsProductDevelopmentForDepartmentF()
        {
            var expected = Department.Product_Development;

            var utility = new Utility();
            var actual = utility.ConvertLetterToDepartment("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsCustodialForDepartmentG()
        {
            var expected = Department.Custodial;

            var utility = new Utility();
            var actual = utility.ConvertLetterToDepartment("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForTwentyThousand()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Twenty Thousand");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor20000()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("20000");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor14000()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidSalary("14000");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor15000()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSalary("15000");

            Assert.AreEqual(expected, actual);
        }
    }
}
