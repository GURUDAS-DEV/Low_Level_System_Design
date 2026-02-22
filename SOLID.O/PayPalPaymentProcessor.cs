public class PayPalPaymentProcessor : PaymentProcessorInterface
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing Payment using Paypal: {amount}");
    }
}