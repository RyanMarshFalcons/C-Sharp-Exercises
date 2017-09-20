using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Account;
using Bank_Account_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var balance = 0.0;
            var amount = 0.0;
            var selectionLetter = "";
            var selection = new Selection();
            while (selection != Selection.CloseAccount)
            {
                selectionLetter = utility.GetSelectionLetter();
                selection = utility.ConvertLetterToSelection(selectionLetter);
                switch (selection)
                {
                    case Selection.Deposit:
                        amount = utility.MakeADeposit();
                        balance = utility.GetNewBalance(balance, amount, selection);
                        Message.ThankYou("deposit");
                        break;
                    case Selection.Withdrawal:
                        amount = utility.MakeAWithdrawal(balance);
                        balance = utility.GetNewBalance(balance, amount, selection);
                        break;
                    case Selection.CheckBalance:
                        Message.ShowCurrentBalance(balance);
                        break;
                    case Selection.CloseAccount:
                        Message.CloseAccount(balance);
                        break;
                    default:
                        break;
                }

            }
            Console.ReadLine();
        }
    }
}
