using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Account_Messages;
using System.Text.RegularExpressions;

namespace Bank_Account
{
    public enum Selection { Deposit, Withdrawal, CheckBalance, CloseAccount};
    public class Utility
    {
        public string GetSelectionLetter()
        {
            var isValidSelection = false;
            Message.Selections();
            var input = "";
            while (isValidSelection == false)
            {
                input = Console.ReadLine();
                if (!CheckIfValidSelection(input))
                {
                    Message.InvalidSelection(input);
                }
                else
                {
                    isValidSelection = true;
                }
            }
            return input;
        }

        public bool CheckIfValidSelection(string input)
        {
            return Regex.IsMatch(input, "^[A-D() ]+$") && input.Length == 1;
        }

        public Selection ConvertLetterToSelection(string letterSelection)
        {
            switch (letterSelection)
            {
                case "A":
                    return Selection.Deposit;
                    break;
                case "B":
                    return Selection.Withdrawal;
                    break;
                case "C":
                    return Selection.CheckBalance;
                    break;
                case "D":
                default:
                    return Selection.CloseAccount;
                    break;
            }
        }

        public double MakeADeposit()
        {
            Message.MakeADeposit();
            return GetAmount("deposit");
        }

        public double MakeAWithdrawal(double balance)
        {
            Message.MakeAWithdrawal();
            var amount = GetAmount("withdrawal");
            if (amount > balance)
            {
                Message.InsufficientFunds(amount, balance);
                return 0;
            }
            else
            {
                Message.ThankYou("withdrawal");
                return amount;
            }
        }

        public double GetAmount(string withdrawOrDeposit)
        {
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfDouble(input) == false)
                {
                    Message.NotANumber(input, withdrawOrDeposit);
                }
                else
                {
                    if (CheckIfPositive(input) == false)
                    {
                        Message.MustBePositive(withdrawOrDeposit);
                    }
                    else
                    {
                        isValidInput = true;
                    }

                }
            }
            return Math.Round(double.Parse(input), 2);
        }

        public bool CheckIfDouble(string input)
        {
            var num = 0.0;
            return double.TryParse(input, out num);
        }

        public bool CheckIfPositive(string input)
        {
            return double.Parse(input) > 0;
        }

        public double GetNewBalance(double originalBalance, double amount, Selection selection)
        {
            if (selection == Selection.Deposit)
            {
                return originalBalance + amount;
            }
            else
            {
                return originalBalance - amount;
            }
        }
    }
}
