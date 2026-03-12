class LegacyGateway
{
    private long transactionReference;
    private bool paymentSuccessful;

    public void ExecuteTransaction(double totalAmount, string currency)
    {
        Console.WriteLine($"LegacyGateway: Executing {currency} {totalAmount}");
        transactionReference = DateTimeOffset.Now.Ticks;
        paymentSuccessful = true;
        Console.WriteLine($"LegacyGateway: Done. Ref: {transactionReference}");
    }

    public bool CheckStatus(long reference)
    {
        Console.WriteLine($"LegacyGateway: Checking status for ref: {reference}");
        return paymentSuccessful;
    }

    public long GetReferenceNumber() => transactionReference;
}