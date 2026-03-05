public class TheFinallyBlock
{
    public static void Run()
    {
        Console.WriteLine("=== Section 4: The Finally Block ===");
        
        StreamReader reader = null;
        try
        {
            reader = new StreamReader("data.txt");
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File not found! " + ex.Message);
        }
        finally
        {
            if (reader != null)
            {
                reader.Close();
                Console.WriteLine("📁 Reader closed in finally block.");
            }
            Console.WriteLine("✅ Finally block always runs!");
        }
    }
}