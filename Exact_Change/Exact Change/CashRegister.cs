using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exact_Change
{
    public class CashRegister
    {
        public string checkCashRegister(decimal changeDue, Dictionary<string, decimal> cashInDrawer)
        {
            var totalOfCashInDrawer = GetTotalOfCashInDrawer(cashInDrawer);
            if (changeDue > totalOfCashInDrawer)
            {
                return "Insufficient Funds";
            }
            else if (changeDue == totalOfCashInDrawer)
            {
                return "Closed";
            }
            else
            {
                return "Sufficient Funds";
            }
        }

        public decimal GetTotalOfCashInDrawer(Dictionary<string, decimal> cashInDrawer)
        {
            return cashInDrawer.Sum(d => d.Value);
        }

        public string GiveProperChange(decimal changeDue, Dictionary<string, decimal> cashInDrawer)
        {
            var changeToGiveToCustomer = GetChange(ref changeDue, cashInDrawer);
            if (changeDue == 0)
            {
                var changeAsString = "";
                foreach (var denominationAmount in changeToGiveToCustomer)
                {
                    changeAsString += denominationAmount;
                }
                return changeAsString;
            }
            return "Insufficient Funds";
        }

        public Dictionary<string, decimal> GetChange(ref decimal changeDue, Dictionary<string, decimal> cashInDrawer)
        {
            var change = new Dictionary<string, decimal>();
            var denominationValueDictionary = new Dictionary<string, decimal>()
                        {
                            {"ONE HUNDRED", 100.00M },
                            {"TWENTY", 20.00M },
                            {"TEN", 10.00M },
                            {"FIVE", 5.00M },
                            {"ONE", 1.00M },
                            {"QUARTER", 0.25M },
                            {"DIME", 0.10M },
                            {"NICKEL", 0.05M },
                            {"PENNY", 0.01M }
                        };
            foreach (var denomination in denominationValueDictionary)
            {
                var tracker = 0.00M;
                while ((denomination.Value <= changeDue) && (cashInDrawer[denomination.Key] > 0))
                {
                    changeDue -= denomination.Value;
                    cashInDrawer[denomination.Key] -= denomination.Value;
                    tracker += denomination.Value;
                }
                if (tracker > 0.00M)
                {
                    change.Add(denomination.Key, tracker);
                }
            }
            return change;
        }
    }
}
