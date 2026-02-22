using System.Text;

class ReportDistributor
{
    public void Distribute(string recipient, StringBuilder csv)
    {
        Console.WriteLine("Sending report to: " + recipient);
        Console.Write(csv.ToString());
        Console.WriteLine("Report sent successfully.");
    }
}