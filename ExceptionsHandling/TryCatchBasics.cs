public class TryCatchBasics
{
    public static void Run()
    {
        Console.WriteLine("=== Section 2: Try / Catch Basics ===");
        
        // Wrap the risky code in try — catch handles the error
        try
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            Console.WriteLine($"Double: {number * 2}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine("Please enter a valid number next time!");
        }
        
        Console.WriteLine("Program continues! No crash.");
    }
}