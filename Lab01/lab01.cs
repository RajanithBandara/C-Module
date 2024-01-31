using System;

public class Lab01{
    public static void Main(string[] args){
        Console.WriteLine("Enter the length of the rectangle: ");
        float length = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the width of the rectangle: ");
        float width = float.Parse(Console.ReadLine());
        float area = length * width;
        Console.WriteLine("The area of the rectangle is: " + area);
    }
}