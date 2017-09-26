using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotational_Cipher;
using Rotational_Cipher_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userMessage = utility.GetValidMessage();
            var rotationAmount = utility.GetValidRotation();
            var encryptedMessage = utility.EncryptMessage(userMessage, rotationAmount);
            Message.DisplayEncryptedMessage(encryptedMessage);
            Console.ReadLine();
        }
    }
}
