using System;

public class Lab01
{
    public static void Main(string[] args)
    {
        int total = 0;
        Console.WriteLine("Enter a Number : ");
        int no = int.Parse(Console.ReadLine());

        if (no < 0)
        {
            Console.WriteLine("Error !");
            Environment.Exit(0);
        }

        while (no > 0)
        {
            total = total + no;
            no--;
        }
        Console.WriteLine("Total sum is : " + total );
    }
}