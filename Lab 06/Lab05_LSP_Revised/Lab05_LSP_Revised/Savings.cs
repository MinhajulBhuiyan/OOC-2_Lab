using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_LSP_Revised
{
    public class Savings : BankAccount, I_Interest
    {
        public Savings(string accountNumber, string accountHolderName, double balance, string signature)
            : base(accountNumber, accountHolderName, balance, signature)
        {

        }

        public override void Withdraw(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Amount <0.");
            }
            if (amount > (balance - 1000))
            {
                Console.WriteLine("Insufficient balance.");
            }
            if (amount > 15000)
            {
                Console.WriteLine(">20000");
            }
            balance -= amount;
        }

        public double CalculateInterest()
        {           
            return balance * 0.10; 
        }
    }
}
