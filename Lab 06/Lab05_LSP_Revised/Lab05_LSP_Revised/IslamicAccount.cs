using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_LSP_Revised
{
    public class IslamicAccount : BankAccount
    {
        public IslamicAccount(string accountNumber, string accountHolderName, double balance, string signature)
            : base(accountNumber, accountHolderName, balance, signature)
        {

        }
        public override void Withdraw(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Amount <0.");
            }
            if (amount > (balance - 200))
            {
                Console.WriteLine("Insufficient balance.");
            }
            if (amount > 10000)
            {
                Console.WriteLine(">10000");
            }
            balance -= amount;
        }

    }

}
