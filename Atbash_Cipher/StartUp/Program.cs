using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atbash_Cipher;
using Atbash_Cipher_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userMessage = utility.GetValidMessage();
            var encryptedMessage = utility.EncryptMessage(userMessage);
            Message.DisplayEncryptedMessage(encryptedMessage);
            Console.ReadLine();
        }
    }
}
