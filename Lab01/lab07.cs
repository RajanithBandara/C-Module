using System;



class ATM
{
    private static int balance;
    public static void deposit(int amount)
    {
        balance = balance + amount;
        Console.WriteLine("Your balance is " + balance);
    }
    public static void withdraw(int amount)
    {
        if (balance < amount)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            balance = balance - amount;
        }
    }
    public static void checkBalance()
    {
        Console.WriteLine("Your balance is " + balance);
    }
}

class Program
{
    static void Main(String[] args)
    {

        int choice = 0;
        int initialBalance = 0;
        while (choice != 4)
        {

            Console.WriteLine("Enter your Choice : ");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");

            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter the amount to deposit : ");
                int depositAmount = int.Parse(Console.ReadLine());
                ATM.deposit(depositAmount);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the amount to withdraw : ");
                int withdrawAmount = int.Parse(Console.ReadLine());
                ATM.withdraw(withdrawAmount);
            }
            else if (choice == 3)
            {
                ATM.checkBalance();
            }
            else if (choice == 4)
            {
                Environment.Exit(0);
            }
        }
    }
}
