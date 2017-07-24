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

       

        public Dictionary<string, decimal> DenominationDictionary()
        {
            return new Dictionary<string, decimal>()
                                                                        {
                                                                            {"HUNDRED", 100M },
                                                                            {"TWENTY", 20M },
                                                                            {"TEN", 10M },
                                                                            {"FIVE", 5M },
                                                                            {"ONE", 1M },
                                                                            {"QUARTER", .25M },
                                                                            {"DIME", .1M },
                                                                            {"NICKEL", .05M },
                                                                            {"PENNY", .01M }

                                                                         };
        }

        public string GiveProperChange(decimal changeDue, Dictionary<string, decimal> cashInDrawer)
        {
            var change = GetChange(ref changeDue, cashInDrawer);
            
            if (changeDue == 0)
            {
                var changeAsString = "";
                foreach (var item in change)
                {
                    changeAsString += item;
                }
                return changeAsString;
            }
            return "Insufficient Funds";
        }

        public Dictionary<string, decimal> GetChange(ref decimal changeDue, Dictionary<string, decimal> cashInDrawer)
        {
            var change = new Dictionary<string, decimal>();
            var denominationValues = DenominationDictionary();
            foreach (var denomination in denominationValues)
            {
                var tracker = 0M;
                while ((denomination.Value <= changeDue) && (cashInDrawer[denomination.Key] > 0))
                {
                    changeDue -= denomination.Value;
                    cashInDrawer[denomination.Key] -= denomination.Value;
                    tracker += denomination.Value;
                }
                if (tracker > 0M)
                {
                    change.Add(denomination.Key, tracker);
                }
            }
            return change;
        }

        public decimal GetTotalOfCashInDrawer(Dictionary<string, decimal> cashInDrawer)
        {
            var totalOfCashInDrawer = 0M;
            foreach (KeyValuePair<string, decimal> denomination in cashInDrawer)
            {
                totalOfCashInDrawer += denomination.Value;
            }
            return totalOfCashInDrawer;
        }

        public string GetMessageToDisplay(decimal changeDue, Dictionary<string, decimal> cashInDrawer)
        {
            var displayMessage = checkCashRegister(changeDue, cashInDrawer);
            if (displayMessage == "Sufficient Funds")
            {
                displayMessage = GiveProperChange(changeDue, cashInDrawer);
            }
            return displayMessage;
        }
    }
}
