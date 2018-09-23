using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWMS.classPackages
{
    class TransactionDtails
    {
        private int transactionId;
        private DateTime timeTransaction;
        private DateTime dateTransaction;
        private int teller;
        private double debit;
        private double credit;
        private double amount;
        void addTransaction(TransactionDtails t) { }
        void removeTransaction(int transactionId) { }
        void updateTransaction(int transactionId) { }
        void searchTransaction(int transactionId) { }
        Order getTransactionById(int transactionId)
        {
            return null;
        }
        void generateTransactionReport(int transactionId) { }
    }
}
