using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_LSP_Revised
{
    public abstract class BankAccount
    {
        public string accountNumber;
        public string accountHolderName;
        public double balance;
        public string signature;

        public BankAccount(string accountNumber, string accountHolderName, double balance, string signature)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.balance = balance;
            this.signature = signature;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount !> 0.");
            }
            balance += amount;
        }

        public virtual void Withdraw(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Amount <0.");
            }
        }
        public double CheckBalance()
        {
            return balance;
        }

    }
}


    









