class Program
{
    public static void Main()
    {
        ProcessPayment process = new ProcessPayment(new PayPalPaymentProcessor());
        process.Processing(120.00);
        ProcessPayment process1 = new ProcessPayment(new UPIPaymentProcessor());
        process1.Processing(190.00);
        ProcessPayment process2 = new ProcessPayment(new PaytmPaymentProcessor());
        process2.Processing(620.00);
    }
}