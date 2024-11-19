using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SavingsAccount : Account , ITransaction
    {
        public string InterestRate { get; set; }

        public string Execute()
        {
            return "Click here to create an Account";
        }

        public void PrintReceipt()
        {
            Console.WriteLine("Click here to print Reciept");
        }

    }
}
