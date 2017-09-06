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
            Console.WriteLine("Hello and welcome to my Company Roster program where you will enter personal information about customers, employees, and managers of your compnay and then I will display that information to you sorted by each person's classifications. Press enter to continue.");
            Console.ReadLine();
        }

        public static void SelectPersonType()
        {
            Console.WriteLine("Select a type of person:\nA) Customer\nB) Employee\nC) Manager");
        }

        public static void NotAValidSelection(string input)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection.\nSelect a type of person:\nA) Customer\nB) Employee\nC) Manager");
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
            Console.Write($"\nYou must input at ten characters for {name}'s {homeBillingShipping} address. Please enter {name}'s {homeBillingShipping} address: ");
        }

        public static void AdressLacksNumbers(string name, string homeBillingShipping)
        {
            Console.Write($"\nYou did not include any numbers for {name}'s {homeBillingShipping} address. Please enter {name}'s {homeBillingShipping} address: ");
        }
    }
}
