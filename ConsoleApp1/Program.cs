// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
int savings = 0;
int option = 0;

do
{
    Console.WriteLine("\nThis is Main Menu\n");
    Console.WriteLine($"Select your type of account \n Select 1 for {AccountType.SavingsAccount} \n Select 2 for {AccountType.CheckingAccount}");

    Console.Write("Input Account Type: ");
    var accountType = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("");
   
        if ((AccountType)accountType == AccountType.SavingsAccount)
    {
        option = 0;

        
        do
        {
            Console.WriteLine("This is Menu");
            Console.WriteLine("click 1 to make a deposit or 2 to make a withdrawal");
            savings = Convert.ToInt32(Console.ReadLine());
            int last = 0;


            if (savings == 1)
            { 

                do
                {
                    Console.WriteLine("Input amount you want to deposit $: ");
                    string deposit = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine($"Successfully deposited ${deposit}\n");
                    Console.WriteLine("Click 1 to make another deposit \nor\npress 9 to go back to Menu\nor \nor press 7 for Main menu to exit");
                    option = Convert.ToInt32(Console.ReadLine());
                }
                while (option == 1);

            }

            else if (savings == 2)
            {
                do

                {
                    Console.WriteLine("Input amount you want to withdraw $: ");
                    string withdrawal = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine($"Successfully withdrawal of ${withdrawal}\n");
                    Console.WriteLine("Click 1 to make another withdrawal \nor\npress 9 to go back ton Menu\nor press 7 for Main menu");
                    option = Convert.ToInt32(Console.ReadLine());

                }
                while (option == 1);
            }

        }
        while (option == 9);
    }

    
    else if((AccountType)accountType == AccountType.CheckingAccount)
    {

    }


    //option = Convert.ToInt32(Console.ReadLine());
}
while ( option == 7);
    // do saving account logic 






    //for withdrawal

    string depositing = Console.ReadLine();
    double ConvertDeposit = Convert.ToDouble(depositing);
    double balance = 0.00;
    double newBalance = ConvertDeposit - balance;
    Console.WriteLine($"This is your new balance $: {newBalance}");

    SavingsAccount savingsAccount = new SavingsAccount();
    savingsAccount.InterestRate = "$ 1.86";
Console.WriteLine(savingsAccount.InterestRate);
//Console.WriteLine(savingsAccount.Method());
//savingsAccount.Deposit(deposit);
// savingsAccount.Withdraw();




//    else if ((AccountType)accountType == AccountType.CheckingAccount)
//{

//        // do checking account logic 
//        CheckingAccount checkingAccount = new CheckingAccount();
//        checkingAccount.AccountNumber = "0012344312";
//        checkingAccount.Balance = 0.00M;
//        //checkingAccount.Deposit();
//        checkingAccount.PrintReceipt();



//    }
//else
//    {
//        Console.WriteLine("Invalid Accout type selected");
//    }
