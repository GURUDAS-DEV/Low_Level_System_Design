public class OrderProcessor
{
    private readonly TaxInterface Taxable;

    public OrderProcessor(TaxInterface Taxable)
    {
        this.Taxable = Taxable;
    }
    public void ProcessOrder( string OrderId, int Amount)
    {
        Console.WriteLine("Calculating Tax for : " + OrderId);
        Taxable.TaxCalculator(Amount);
        Console.WriteLine(" ");
    }
}