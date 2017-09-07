using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Roster_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Company Roster program where you will enter personal information about customers and employees of your compnay and then I will display that information to you sorted by each person's classifications. Press enter to continue.");
            Console.ReadLine();
        }

        public static void SelectPersonType()
        {
            Console.WriteLine("Select a type of person:\nA) Customer\nB) Employee");
        }

        public static void NotAValidPersonTypeSelection(string input)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection.\nSelect a type of person:\nA) Customer\nB) Employee");
        }

        public static void AddAnotherPerson()
        {
            Console.Write("\nWould you like to enter person animal? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please input y or n to procede: ");
        }

        public static void AskName(string personType, string firstLast)
        {
            Console.Write($"\nPlease enter the {firstLast} name of the {personType}: ");
        }

        public static void NameNotLongEnough(string personType, string firstLast)
        {
            Console.Write($"\nYou must input at least one character for a {personType}'s {firstLast} name. Please enter the {firstLast} name of the {personType}: ");
        }

        public static void AskPrefix(string name)
        {
            Console.WriteLine($"\nPlease select the prefix before {name}'s name:\nA) Mr.\nB) Mrs.\nC) Ms.\nD) Miss.");
        }

        public static void InvalidPrefixSelection(string input, string name)
        {
            Console.WriteLine($"Sorry but {input} is an invalid selection.\nPlease select the prefix before {name}'s name:\nA) Mr.\nB) Mrs.\nC) Ms.\nD) Miss.");
        }

        public static void AskEmail(string name)
        {
            Console.Write($"\nPlease enter {name}'s e-mail address: ");
        }

        public static void EmailNotLongEnough(string name)
        {
            Console.Write($"\nYou must input at seven characters for {name}'s email address. Please enter {name}'s e-mail address: ");
        }

        public static void EmailLacksAtAndDot(string name)
        {
            Console.Write($"\nYou must include both an \"@\" symbol and a \".\" symbol for a valid email address. Please enter {name}'s e-mail address: ");
        }

        public static void AskAddress(string name, string homeBillingShipping)
        {
            Console.Write($"Please enter {name}'s {homeBillingShipping} address: ");
        }

        public static void AdressNotLongEnough(string name, string homeBillingShipping)
        {
            Console.Write($"\nYou must input at fifteen characters for {name}'s {homeBillingShipping} address. Please enter {name}'s {homeBillingShipping} address: ");
        }

        public static void AdressLacksNumbers(string name, string homeBillingShipping)
        {
            Console.Write($"\nYou did not include any numbers for {name}'s {homeBillingShipping} address. Please enter {name}'s {homeBillingShipping} address: ");
        }

        public static void AskPhoneNumber(string name)
        {
            Console.Write($"Please enter {name}'s phone number: ");
        }

        public static void PhoneNumberNotLongEnough(string name)
        {
            Console.Write($"\nYou must input at ten characters for {name}'s phone number. Please enter {name}'s phone number: ");
        }

        public static void PhoneNumberHasLetters(string name)
        {
            Console.Write($"\nPhone numbers cannot contain letters. Please enter {name}'s phone number: ");
        }

        public static void AskCreditCardNumber(string name)
        {
            Console.Write($"Please enter {name}'s credit card number, digits only no symbols or spaces: ");
        }

        public static void CreditCardNotAllNumbers(string name)
        {
            Console.Write($"Sorry but the credit card number must only contain numbers. Please enter {name}'s credit card number, digits only no symbols or spaces: ");
        }

        public static void InvalidCreditCardLength(string name)
        {
            Console.Write($"Sorry but the credit card number must be between 13 and 16 digits. Please enter {name}'s credit card number, digits only no symbols or spaces: ");
        }

        public static void AskJobTitle(string name)
        {
            Console.Write($"Please enter {name}'s job title: ");
        }

        public static void JobTitleTooShort(string name)
        {
            Console.Write($"Sorry but a job title must be at least 4 characters long. Please enter {name}'s job title: ");
        }

        public static void AskDepartment(string name, string jobTitle)
        {
            Console.WriteLine($"What department is {name} a {jobTitle} in:\nA) Accounting\nB) IT\nC) Sales\nD) Human Resources\nE) Customer Service\nF) Product Development\nG) Custodial");
        }

        public static void InvalidDepartmentSelection(string input, string name, string jobTitle)
        {
            Console.WriteLine($"Sorry but {input} is not a valid department selection.\nWhat department is {name} a {jobTitle} in:\nA) Accounting\nB) IT\nC) Sales\nD) Human Resources\nE) Customer Service\nF) Product Development\nG) Custodial");
        }

        public static void AskSalary(string name, string jobTitle, string department)
        {
            Console.Write($"What is {name}'s annual salary as a {jobTitle} in the {department} department: $");
        }

        public static void SalaryNotANumber(string input, string name, string jobTitle, string department)
        {
            Console.Write($"Sorry but {input} is not a number. What is {name}'s annual salary as a {jobTitle} in the {department} department: $");
        }

        public static void SalaryTooLow(string name, string jobTitle, string department)
        {
            Console.Write($"Sorry but an annual salary must be at least $15,000. What is {name}'s annual salary as a {jobTitle} in the {department} department: ");
        }
    }
}
