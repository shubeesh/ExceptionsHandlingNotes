public class InsufficientFundsException : Exception
{
    public decimal AttemptedAmount { get; }
    public decimal CurrentBalance { get; }

    public InsufficientFundsException(decimal attempted, decimal balance)
        : base($"Cannot withdraw {attempted:C}. Balance: {balance:C}")
    {
        AttemptedAmount = attempted;
        CurrentBalance = balance;
    }
}

public class CustomExceptions
{
    public static void Run()
    {
        Console.WriteLine("=== Section 7: Custom Exceptions ===");
        
        decimal balance = 100.00m;
        decimal withdrawal = 250.00m;
        
        try
        {
            if (withdrawal > balance)
                throw new InsufficientFundsException(withdrawal, balance);
            
            balance -= withdrawal;
            Console.WriteLine($"Withdrawal successful. New balance: {balance:C}");
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine($"Short by: {ex.AttemptedAmount - ex.CurrentBalance:C}");
        }
    }
}