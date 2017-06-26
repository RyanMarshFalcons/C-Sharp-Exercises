using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exact_Change
{
    public class CashRegister
    {
        public string checkCashRegister(decimal price, decimal cash, Dictionary<string, decimal> cashInDrawer)
        {
            var changeDue = cash - price;
            var totalOfCashInDrawer = 0M;

            foreach(KeyValuePair < string, decimal > denomination in cashInDrawer)
            {
                totalOfCashInDrawer += denomination.Value;
            }

            if (changeDue > totalOfCashInDrawer)
            {
                return "Insufficient Funds";
            }

            if (changeDue == totalOfCashInDrawer)
            {
                return "Closed";
            }

            var denominationValues = new Dictionary<string, decimal>()
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

            var change = new Dictionary<string, decimal>();
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
    }
}
