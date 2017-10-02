using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sock_Merchant;
using Sock_Merchant_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var sockPile = new List<Color>();
            var counter = 0;
            var continueAsking = true;
            while (continueAsking)
            {
                counter++;
                sockPile.Add(utility.GetValidColorSelection(counter));
                if (counter > 3)
                {
                    continueAsking = utility.AskToAddAnotherSock();
                }
            }
            var sockTracker = utility.GetMatchingPairs(sockPile);
            utility.DisplayResults(sockTracker);
            Console.ReadLine();
        }
    }
}
