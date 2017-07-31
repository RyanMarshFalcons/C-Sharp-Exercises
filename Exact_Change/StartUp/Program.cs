using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exact_Change;


namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var priceInput = Console.ReadLine();
            var evaluation = new Evaluation();
            var price = 0.0M;
            if (evaluation.IsAValidDecimal(priceInput) == true)
            {
                price = evaluation.ConvertToADecimal(priceInput);
            }
            else
            {
                evaluation.InvalidDecimal(priceInput);
            }
            Message.GetCash();
            var cashInput = Console.ReadLine();
            var cash = 0.0M;
            if (evaluation.IsAValidDecimal(cashInput) == true)
            {
                cash = evaluation.ConvertToADecimal(cashInput);
            }
            else
            {
                evaluation.InvalidDecimal(cashInput);
            }
            var changeDue = cash - price;
            Message.AskWhatsInDrawer();
            var cashInDrawer = evaluation.LogOfDenominationsInDrawer();
            var cashRegister = new CashRegister();
            var displayMessage = cashRegister.GetMessageToDisplay(changeDue, cashInDrawer);
            Message.GiveChange(displayMessage);
            Console.ReadLine();
        }
    }
}
