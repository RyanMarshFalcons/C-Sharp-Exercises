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
            var price = evaluation.EvaluateDecimal(priceInput);
            Message.GetCash();
            var cashInput = Console.ReadLine();
            var cash = evaluation.EvaluateDecimal(cashInput);
            Message.AskWhatsInDrawer();
            var cashInDrawer = evaluation.LogOfDenominationsInDrawer();
            var cashRegister = new CashRegister();
            var changeDue = cashRegister.checkCashRegister(price, cash, cashInDrawer);
            Message.GiveChange(changeDue);
            Console.ReadLine();
        }
    }
}
