public class ProcessPayment
{
    private readonly PaymentProcessorInterface Payment;

    public ProcessPayment(PaymentProcessorInterface Payment)
    {
        this.Payment = Payment;
    }
    public void Processing(double amount)
    {
        Payment.ProcessPayment(amount);
    }
}