using System;

public class BankAccount
{
    private static int Account_Number = 10001;
    private static int Account_Number2 = 10002;
    private static int Balance = 0;
    private static int Balance2 = 0;
    private static int optionselect;

    public int accno;
    public int balance;

    public BankAccount(int AccNo)
    {
        this.accno = AccNo;
    }

    static void add1(int amount)
    {
        Balance += amount;
    }
    static void add2(int amount)
    {
        Balance2 += amount;
    }
    static void withdraw(int amount)
    {
        Balance -= amount;
    }
    static void withdraw2(int amount)
    {
        Balance2 -= amount;
    }
    static void displayoptiona()
    {
        Console.WriteLine("Select the option you need : ");
        Console.WriteLine("To deposit press 1 : ");
        Console.WriteLine("To withdraw press 2 : ");
        Console.WriteLine("To end the program press 3 :");
        optionselect = int.Parse(Console.ReadLine());
        if (optionselect == 1)
        {
            Console.WriteLine("Enter the Amount : ");
            int Amount;
            Amount = int.Parse(Console.ReadLine());
            add1(Amount);
            Console.WriteLine(Balance);
            displayoptiona();
            //checkAccount(accno);
        }
        else if (optionselect == 2)
        {
            Console.WriteLine("Enter the Amount : ");
            int Amount;
            Amount = int.Parse(Console.ReadLine());
            withdraw(Amount);
            Console.WriteLine(Balance);
            displayoptiona();
            //checkAccount(accno);
        }
        if (optionselect == 3)
        {
            Environment.Exit(0);
        }
    }


    public static void checkAccount(int accno)
    {
        if (accno == 10001)
        {
            displayoptiona();
            
        }
        else if (accno == 10002)
        {
            displayoptiona();
            
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your Account Number : ");
        int Account_Number;
        Account_Number = int.Parse(Console.ReadLine());
        BankAccount.checkAccount(Account_Number);
    }
}