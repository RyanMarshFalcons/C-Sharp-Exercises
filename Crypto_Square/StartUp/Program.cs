using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crypto_Square;
using Crypto_Square_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userMessage = utility.GetValidMessage();
            var normalizedMessage = utility.NormalizeText(userMessage);
            var width = utility.GetWidth(normalizedMessage);
            var rowsOftext = utility.ConstructRows(normalizedMessage, width);
            Message.DisplayCryptoSquare(rowsOftext);
            Console.ReadLine();
        }
    }
}
