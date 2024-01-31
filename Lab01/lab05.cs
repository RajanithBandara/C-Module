using System;

class FibonacciRecursion
{
    public static void Main(String[] args)
    {
        Console.Write("Enter Your Name : ");
        string name = Console.ReadLine();
        Console.Write("Enter Your Marks : ");
        int mark = int.Parse(Console.ReadLine());
        string grade = "";

        if (mark > 100 || mark < 0)
        {
            Console.WriteLine("Error, invalid marks");
            Environment.Exit(0);
        }

        if (mark>74 && mark <= 100)
        {
            grade = "A";
        }
        else if (mark<75 && mark >= 60)
        {
            grade = "B";
        }
        else if (mark<60 && mark >= 50)
        {
            grade = "C";
        }
        else if (mark<50 && mark >= 40)
        {
            grade = "D";
        }
        else if (mark<40 && mark >= 0)
        {
            grade = "F";
        }

        Console.WriteLine("Hello " + name + " Your Grade is " + grade);
        if (grade == "F")
        {
            Console.WriteLine("You Failed");
        }
    }
}
