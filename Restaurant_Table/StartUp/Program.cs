using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Table;
using Restaurant_Table_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var yourFashion = utility.GetValidNumber("are you");
            var datesFashion = utility.GetValidNumber("is your date");
            var youFashionable = utility.FashionableEnough(yourFashion);
            var datesFashionable = utility.FashionableEnough(datesFashion);
            var day = utility.GetValidDay();
            var isWeekend = utility.IsWeekEnd(day);
            var getTable = utility.GetTable(youFashionable, datesFashionable, isWeekend);
            utility.DisplayResults(getTable);
            Console.ReadLine();
        }
    }
}
