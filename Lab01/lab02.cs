using System;

public class Lab01
{
    public static void Main(string[] args)
    {
        int[] arraynum = new int[10];
        for (int x = 0; x<10; x++)
        {
            Console.Write("Enter the Number " + (x+1) + ": ");
            int number = int.Parse(Console.ReadLine());
            arraynum[x] = number;
        }

        for (int x=0; x<10; x++)
        {
            int remain = arraynum[x] % 2;
            if (remain == 0)
            {
                Console.WriteLine(+arraynum[x] + " is an even number.");
            }
            else if (remain == 1)
            {
                Console.WriteLine(+arraynum[x] + " is an odd number.");
            }
        }
    }
}