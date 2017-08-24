using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Get_Outside_Sandwich;
using Get_Outside_Sandwich_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetValidString();
            var startOfSandwich = utility.GetIndexOfFirstSlice(userString);
            var endOfSandwich = utility.GetIndexOfSecondSlice(userString);
            if (endOfSandwich != startOfSandwich)
            {
                var newString = utility.CreateNewString(userString, startOfSandwich, endOfSandwich);
                Message.WasASandwich(newString);
            }
            else
            {
                Message.WasNotASandwich();
            }
            Console.ReadLine();
        }
    }
}
