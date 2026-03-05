public class ExceptionProperties
{
    public static void Run()
    {
        Console.WriteLine("=== Section 5: Exception Properties ===");
        
        try
        {
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(arr[10]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Message:    {ex.Message}");
            Console.WriteLine($"StackTrace: {ex.StackTrace}");
            Console.WriteLine($"Source:     {ex.Source}");
            Console.WriteLine($"Inner:      {ex.InnerException}");
        }
    }
}