public class PaytmPaymentProcessor : PaymentProcessorInterface
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing Payment using Paytm: {amount}");
    }
}