public class UKTaxCalculator : TaxInterface
{
    public void TaxCalculator(int amount)
    {
        double tax = amount * 0.15;
        double total = tax + amount;
        Console.WriteLine($"UK Tax on {amount} is {tax} and total tax is {total}");
    }
}