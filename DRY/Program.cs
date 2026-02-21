class Program
{
    public static void Main()
    {
        OrderProcessor Process = new OrderProcessor(new EUTaxCalculator());
        Process.ProcessOrder("O123", 100);
        OrderProcessor Process1 = new OrderProcessor(new UKTaxCalculator());
        Process1.ProcessOrder("O123", 150);
        OrderProcessor Process2 = new OrderProcessor(new USTaxCalculator());
        Process2.ProcessOrder("O123", 900);
    }
}       