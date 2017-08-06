using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Account_Messages;

namespace Bank_Account
{
    public enum Selection { Deposit, Withdrawal, CheckBalance, CloseAccount};
    public class Utility
    {
        public Selection GetSelection()
        {
            var isValidSelection = false;
            var selection = new Selection();
            var input = "";
            Message.Selections();
            while (isValidSelection == false)
            {
                input = Console.ReadLine();
                if ((input != "1") && (input != "2") && (input != "3") && (input != "4"))
                {
                    Message.Not123or4(input);
                }
                else
                {
                    isValidSelection = true;
                }
            }
            switch (input)
            {
                case "1":
                    return Selection.Deposit;
                    break;
                case "2":
                    return Selection.Withdrawal;
                    break;
                case "3":
                    return Selection.CheckBalance;
                    break;
                case "4":
                default:
                    return Selection.CloseAccount;
                    break;
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
            return Math.Round(Double.Parse(input), 2);
        }

        public bool CheckIfDouble(string input)
        {
            var num = 0.0;
            return Double.TryParse(input, out num);
        }

        public bool CheckIfPositive(string input)
        {
            return Double.Parse(input) > 0;
        }

        public double MakeADeposit()
        {
            Message.MakeADeposit();
            var utility = new Utility();
            return utility.GetAmount("deposit");
        }

        public double MakeAWithdrawal(double balance)
        {
            Message.MakeAWithdrawal();
            var utility = new Utility();
            var amount = utility.GetAmount("withdrawal");
            if (amount > balance)
            {
                Message.InsufficientFunds(amount, balance);
                return 0;
            }
            else
            {
                return amount;
            }
        }
    }
}
