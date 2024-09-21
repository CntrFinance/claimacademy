using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CashRegisterApp
{       // this list is to decide what properties are to be stored from our transaction. What information from the transaction data do we want stored?

    public class TransactionRecord
    {
        public decimal SaleAmount { get; set; }
        public decimal CashGiven { get; set; }
        public decimal ChangeGiven { get; set; }

        public TransactionRecord(decimal saleAmount, decimal cashGiven, decimal changeGiven)
        {
            SaleAmount = saleAmount;
            CashGiven = cashGiven;
            ChangeGiven = changeGiven;
        }
    }
}
