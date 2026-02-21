public class USTaxCalculator : TaxInterface
{
     public void TaxCalculator(int amount)
    {
        double tax = amount * 0.10;
        double total =  tax + amount;
        Console.WriteLine($"USA Tax on {amount} is {tax} and total tax is {total}");
    }
}