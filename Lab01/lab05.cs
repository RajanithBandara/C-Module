using System;

class MultiplicationTable
{
    static void Main()
    {
        Console.WriteLine("Enter a number to display its multiplication table:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nMultiplication Table for {number}:");

        for (int i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
        }
    }
}
