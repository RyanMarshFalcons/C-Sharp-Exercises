using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chocolate_Feast_Messages;

namespace Chocolate_Feast
{
    public class Utility
    {
        public int GetPriceOfChocolateBar()
        {
            Message.EnterPriceOfChocolateBar();
            var isValidInput = false;
            var input = "";
            while (!isValidInput)
            {
                input = Console.ReadLine();
                if (!CheckIfInt(input))
                {
                    Message.PriceNotANumber(input);
                }
                else
                {
                    if (!CheckIfPositive(input))
                    {
                        Message.PriceMustBePositive();
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public int GetNumberOfDollars(int priceOfChocolateBar)
        {
            Message.EnterNumberOfDollars();
            var isValidInput = false;
            var input = "";
            while (!isValidInput)
            {
                input = Console.ReadLine();
                if (!CheckIfInt(input))
                {
                    Message.DollarsNotANumber(input);
                }
                else
                {
                    if (!CheckIfPositive(input))
                    {
                        Message.DollarsMustBePositive();
                    }
                    else if (!CheckIfHaveEnoughCash(input, priceOfChocolateBar))
                    {
                        Message.DollarsMustBeAtLeastPrice();
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public int GetWrapperExchangeRate()
        {
            Message.EnterWrapperExchangeRate();
            var isValidInput = false;
            var input = "";
            while (!isValidInput)
            {
                input = Console.ReadLine();
                if (!CheckIfInt(input))
                {
                    Message.ExchangeRateNotANumber(input);
                }
                else
                {
                    if (!CheckIfAtLeastTwo(input))
                    {
                        Message.ExchangeRateMustBeAtLeastTwo();
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return int.TryParse(input, out num);
        }

        public bool CheckIfPositive(string input)
        {
            return int.Parse(input) > 0;
        }

        public bool CheckIfHaveEnoughCash(string input, int priceOfChocolateBar)
        {
            return int.Parse(input) >= priceOfChocolateBar;
        }

        public bool CheckIfAtLeastTwo(string input)
        {
            return int.Parse(input) >= 2;
        }

        public int CalculateChocolatesEaten(int numDollars, int priceOfChocolateBar, int numWrappersForFreeChocolate)
        {
            var totalChocolatesEaten = 0;
            var numWrappersLeft = 0;
            while (numDollars >= priceOfChocolateBar)
            {
                numDollars -= priceOfChocolateBar;
                totalChocolatesEaten++;
            }
            Message.BuyChocolateBars(priceOfChocolateBar * totalChocolatesEaten, priceOfChocolateBar, totalChocolatesEaten);
            numWrappersLeft = totalChocolatesEaten;
            while(numWrappersLeft >= numWrappersForFreeChocolate)
            {
                numWrappersLeft -= numWrappersForFreeChocolate;
                totalChocolatesEaten++;
                numWrappersLeft++;
                Message.ExchangeWrappersForChocolateBar(numWrappersForFreeChocolate, numWrappersLeft);
            }
            return totalChocolatesEaten;
        }
    }
}
