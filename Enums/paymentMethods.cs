public enum paymentMethodsEnum
{
    UPI, 
    Debit_Card,
    Credit_Card, 
    Net_Banking, 
    Amazon_Pay,
    Not_Given
}

public class PaymentMethods
{
    private paymentMethodsEnum UsedMethods = paymentMethodsEnum.Not_Given;

    public PaymentMethods(paymentMethodsEnum selectedPaymentMethod)
    {   
        UsedMethods = selectedPaymentMethod;
    }    

    public void ProcessPayment()
    {
        Console.WriteLine($"{UsedMethods} is Processing");
    }
}