using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_11__homework
{
    class BankAccount
    {
        private string bankName;
        private double accountNumber;
        private double balance;
        public BankAccount(string bankname, double accountnumber, double ytra)
        {
            bankName = bankname;
            accountNumber = accountnumber;
            balance = ytra;
        }
        public void WithdrawOrDeposit(double addBalance)
        {
            balance += addBalance;
        }
        public string GetAccountDetails()
        {
            return $"bank name:{bankName} account number : {accountNumber}";
        }

    }
}
