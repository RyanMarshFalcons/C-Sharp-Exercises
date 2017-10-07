using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolate_Feast_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Chocolate Feast program. You are a chocolate lover who is going toa candy shop. You only have so many dollars to spend on buying your favorite\nchocolate bars but the candy shop also has a promotion where you can exchange\nwrappers from chocolate bars that you've eaten for more chocolate bars. Based onthe number of dollars you have to spend, the cost of your favorite chocolate\nbars, and how many wrappers the candy shop requires in exchange for more\nchocolate bars, I will calculate how many chocolate bars you can consume during your chocolate feast. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterPriceOfChocolateBar()
        {
            Console.Write($"Please enter how many dollars your favorite chocolate bar costs: ");
        }

        public static void PriceNotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter how many\ndollars your favorite chocolate bar costs: ");
        }

        public static void PriceMustBePositive()
        {
            Console.Write($"\nSorry but the price of a chocolate bar must be positive. Please enter how many\ndollars your favorite chocolate bar costs: ");
        }

        public static void EnterNumberOfDollars()
        {
            Console.Write($"\nPlease enter how many dollars you have available to spend on buying chocolate\nbars: ");
        }

        public static void DollarsNotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter how\nmany dollars you have available to spend on buying chocolate bars: ");
        }

        public static void DollarsMustBePositive()
        {
            Console.Write($"\nSorry but the number of dollars you have must be positive. Please enter how manydollars you have available to spend on buying chocolate bars: ");
        }

        public static void DollarsMustBeAtLeastPrice()
        {
            Console.Write($"\nSorry but you need to bring at least enough money to buy one chocolate bar.\nPlease enter how many dollars you have available to spend on buying chocolate\nbars: ");
        }

        public static void EnterWrapperExchangeRate()
        {
            Console.Write($"\nPlease enter how many used wrappers the candy shop will accept in exchange for\nan unopened candy bar: ");
        }

        public static void ExchangeRateNotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter how many\nused wrappers the candy shop will accept in exchange for an unopened candy\nbar: ");
        }

        public static void ExchangeRateMustBeAtLeastTwo()
        {
            Console.Write($"\nSorry but the number of wrappers must be at least two. Please enter how many\nused wrappers the candy shop will accept in exchange for an unopened candy\nbar: ");
        }

        public static void BuyChocolateBars(int numDollarsSpent, int priceOfChocolateBar, int chocolatesBought)
        {
            Console.WriteLine($"\nWhen you arrive in the candy shop you spend {numDollarsSpent.ToString("C")} to buy {chocolatesBought} chocolate bars\nat {priceOfChocolateBar.ToString("C")} apiece. After eating the {chocolatesBought} chocolate bars you now have {chocolatesBought} wrappers.\nPress enter to continue.");
            Console.ReadLine();
        }

        public static void ExchangeWrappersForChocolateBar(int numWrappersForFreeChocolate, int numWrappersLeft)
        {
            Console.WriteLine($"\nAfter exchanging {numWrappersForFreeChocolate} wrappers for another chocolate bar and then eating that\nchocolate bar you now have {numWrappersLeft} wrappers left. Press enter to continue.");
            Console.ReadLine();
        }

        public static void DisplayResults(int chocolatesEaten)
        {
            Console.WriteLine($"\nCongratulations your chocolate feast was a success and in all you were able to\nconsume {chocolatesEaten} chocolate bars!!! Press enter to close the program.");
        }
    }
}
