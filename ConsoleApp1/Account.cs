using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public string Deposit(string amount) {
            double ConvertDeposit = Convert.ToDouble(amount);
            double newSum = ConvertDeposit;
            return $" Deposite successful, Your neww balance is : {newSum}";
        }


        public string Withdraw(string amount) {

            return ($"Successfully withrawal of {amount}");
        }        
    }


    public enum AccountType
    {
        SavingsAccount = 1,
        CheckingAccount
    }
}
