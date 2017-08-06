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
            var selection = new Selection();
            while (selection != Selection.CloseAccount)
            {
                selection = utility.GetSelection();
                switch (selection)
                {
                    case Selection.Deposit:
                        balance += utility.MakeADeposit();
                        break;
                    case Selection.Withdrawal:
                        balance -= utility.MakeAWithdrawal(balance);
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
