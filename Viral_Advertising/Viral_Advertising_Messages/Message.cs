using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viral_Advertising_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Viral Advertising program. You are a business owner who is about\nto launch a new product and are going to advertise it on social media. Each day half of the people (rounded down for an odd number of people) who see your\nadvertisent will like it and will each share it with three of their friends.\nPress enter to continue.");
            Console.ReadLine();
        }

        public static void EnterNumberOfPeople()
        {
            Console.Write("Please enter the number of people that you are going to send your viral\nadvertisement to on the first day: ");
        }

        public static void NumberOfPeopleNotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter the number of\npeople that you are going to send your viral advertisement to on the first\nday: ");
        }

        public static void NumberOfPeopleMustBeAtLeastFour()
        {
            Console.Write("\nSorry but you must send the advertisement out to at least four people in order\nfor it to be able to go viral. Please enter the number of people that you are\ngoing to send your viral advertisement to on the first day: ");
        }

        public static void EnterNumberOfDays()
        {
            Console.Write("\nPlease enter after how many number of days you want to check the total number ofpeople who will have liked your viral advertisement by: ");
        }

        public static void NumberOfDaysNotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter after how\nmany number of days you want to check the total number of people who will have\nliked your viral advertisement by: ");
        }

        public static void NumberOfDaysMustBeAtLeastTwo()
        {
            Console.Write("\nSorry but your advertising campaign must last for at least two days in order\nfor it to be able to go viral. Please enter after how many number of days you\nwant to check the total number of people who will have liked your viral\nadvertisement by: ");
        }

        public static void DisplayResult(int initialNumPeople, int numDays, int totalLikes)
        {
            Console.WriteLine($"\nYou initially sent out your viral advertisement to {initialNumPeople} people and now after\n{numDays} days it has been liked by a total of {totalLikes} people. Press enter to close\nthe program.");
        }
    }
}
