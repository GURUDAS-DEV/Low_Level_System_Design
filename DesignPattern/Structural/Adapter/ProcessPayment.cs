public class ProcessPaymentClass : IProcessPayment
{
    private string transactionId;
    private bool paymentSuccessful;

    ProcessPaymentClass()
    {
        transactionId = "TXN_" + DateTimeOffset.Now.ToUnixTimeMilliseconds();
        paymentSuccessful = true;
    }
    public void Processing(double amount, string currency)
    {
        Console.WriteLine("Processing Payment : " + amount);
        
        Console.WriteLine($"InHouseProcessor: Success. Txn ID: {transactionId}");

    }
    public bool IsPaymentSuccessfully() => paymentSuccessful;
    public string GetId() => transactionId;
}