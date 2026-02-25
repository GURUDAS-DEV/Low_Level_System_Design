public class FullDevice : IScanable, IPrintable, IFaxable, IStaple
{
    public void Print(string Document)
    {
        Console.WriteLine("Printing: " + Document);
    }

    public void Scan(string Document)
    {
        Console.WriteLine("Scanning: " + Document);
    }

    public void Staple(string Document)
    {
        Console.WriteLine("Stapling: " + Document);
    }

    public void Fax(string Document)
    {
        Console.WriteLine("Faxing: " + Document);
    }
}