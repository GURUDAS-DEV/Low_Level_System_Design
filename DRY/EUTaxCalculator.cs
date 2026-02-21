public class EUTaxCalculator : TaxInterface
{
    public void TaxCalculator(int amount)
    {
        double tax = amount * 0.20;
        double total = tax + amount;

        Console.WriteLine($"European Tax on {amount} is {tax} and total tax is {total}");
    }
}