public class WhatAreExceptions
{
    public static void Run()
    {
        Console.WriteLine("=== Section 1: What Are Exceptions? ===");
        
        // This code compiles fine but will crash at runtime!
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        Console.WriteLine($"You entered: {number}");
            
        Console.Write("Hello: ");
        int hello = int.Parse(input);
        Console.WriteLine($"You entered: {hello}");
        
    }
}