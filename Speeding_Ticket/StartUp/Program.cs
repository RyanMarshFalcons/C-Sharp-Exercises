using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Speeding_Ticket;
using Speeding_Ticket_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var driverSpeed = utility.GetValidEntry();
            var mphOver = utility.GetmphOver(driverSpeed);
            utility.DisplayResults(mphOver);
            Console.ReadLine();
        }
    }
}
