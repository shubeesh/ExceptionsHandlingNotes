public class MultipleCatchBlocks
{
    public static void Run()
    {
        Console.WriteLine("=== Section 3: Multiple Catch Blocks ===");
        
        try
        {
            Console.Write("Enter an index (0-4): ");
            int index = int.Parse(Console.ReadLine());
            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine($"Value: {numbers[index]}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("That wasn't a number!");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Index must be 0-4. {ex.Message}");
        }
    }
}