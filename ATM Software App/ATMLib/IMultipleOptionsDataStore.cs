using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLib
{
    internal interface IMultipleOptionsDataStore
    {
        double ViewAccountBalance(int userID);

        int CashDeposit(int userID, double amount);

        int CashWithdraw(int userID, double amount);

        List<Transactions> PrevTransactionDetails(int userId);
    }
}
