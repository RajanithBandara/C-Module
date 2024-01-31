using System;

class FibonacciRecursion
{
    static void Main()
    {
        Console.WriteLine("Enter the number of Fibonacci terms to print:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nFirst {n} terms of Fibonacci series:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
