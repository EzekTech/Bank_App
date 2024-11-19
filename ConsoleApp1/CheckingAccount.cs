using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CheckingAccount : Account , ITransaction
    {
        public double WriteCheck { get; set; }

        public string Execute()
        {
            return "Click to check account details";
        }

        public void PrintReceipt()
        {
            Console.WriteLine("Click to print transaction reciept");
        }
        decimal balance = 0.00M;

        public void Deposit(string amount, string newbalance)
        {
            decimal deposit = Convert.ToDecimal(Console.ReadLine());
          //  return "Click to check deposit history";
          //newbalance = 10 + deposit;
        }

        public string Withdraw(decimal amount)
        {
            return "Click to check withdrawal history";
        }


    }
}
