public class BasicPrinter : IPrintable
{
    public void Print(string Document)
    {
        Console.WriteLine("Printing: " + Document);
    }
}