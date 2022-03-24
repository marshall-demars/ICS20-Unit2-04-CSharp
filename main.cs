// Created by: Marshall Demars
// Created on: Mar 2022
//
// This program accepts user input

using System;

class Program
{
  public static void Main(string[] args)
    {
        // This function accepts user input
        int baseTriangle;
        int heightTriangle;

        Console.WriteLine("This program finds the area of a triangle");
        Console.WriteLine("");

        Console.Write("Enter the height: ");
        heightTriangle = Console.ReadLine();
        Console.Write("Enter the base: ");
        heightBase = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("The area is: " + (heightTriangle * baseTriangle) / 2 + " " + ".");

        Console.WriteLine("\nDone.");
    }
}
