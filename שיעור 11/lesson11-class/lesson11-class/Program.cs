using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson11_class
{
    class Program
    {
        static void Main(string[] args)
        {
            #region tirgul 1
            //BankAcouunt b1 = new BankAcouunt("avicii", 214486, 20001);
            //b1.GetAccountDetails();
            #endregion

            #region tirgul 2
            //Person p1 = new Person("luffy", "315448679");
            //Person.ChangeName(p1, "avicii");
            #endregion
        }

    }
    internal class BankAcouunt
    {
        private string bankName;
        private double accountNumber;
        private double balance;
        public BankAcouunt(string bankname, double accountnumber, double ytra)
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

    class Person
    {
        private string name;
        private string iD;
        private static double NumberOfPeople;

        public Person(string name, string iD)
        {
            this.name = name;
            this.iD = iD;
            Person.NumberOfPeople++;
        }
        public static void ChangeName(Person p,string name)
        {
            p.name = name;
        }
    }
}
