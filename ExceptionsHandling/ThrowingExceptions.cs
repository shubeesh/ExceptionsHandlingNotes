public class ThrowingExceptions
{
    static void SetAge(int age)
    {
        if (age < 0 || age > 150)
        {
            throw new ArgumentOutOfRangeException(nameof(age),
                "Age must be between 0 and 150.");
        }
        Console.WriteLine($"Age set to: {age}");
    }
    
    public static void Run()
    {
        Console.WriteLine("=== Section 6: Throwing Exceptions ===");
        
        try
        {
            SetAge(25);   // works fine
            SetAge(-5);   // throws!
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Invalid age: {ex.Message}");
        }
    }
}