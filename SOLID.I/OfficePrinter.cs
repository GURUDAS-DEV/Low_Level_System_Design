public class OfficePrinter : IScanable, IPrintable, IFaxable
{
    public void Print(string Document)
    {
        Console.WriteLine("Printing: " + Document);
    }

    public void Scan(string Document)
    {
        Console.WriteLine("Scanning: " + Document);
    }

    public void Fax(string Document)
    {
        Console.WriteLine("Faxing: " + Document);
    }
}