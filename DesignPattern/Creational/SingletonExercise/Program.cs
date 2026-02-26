class Program
{
    public static void Main()
    {
        var count1 = Counter.Instance;
        InternalIncrement(count1, 10);   
        Console.WriteLine(count1.GetCounter());

        Counter count2 = Counter.Instance;
        InternalIncrement(count2, 12);   
        Console.WriteLine(count2.GetCounter());

        Counter count3 = Counter.Instance;
        InternalIncrement(count3, 5);   
        Console.WriteLine(count3.GetCounter());

        Counter count4 = Counter.Instance;
        InternalIncrement(count4, 8);   
        Console.WriteLine(count4.GetCounter());

        Counter count5 = Counter.Instance;
        InternalIncrement(count5, 0);   
        Console.WriteLine(count5.GetCounter());
        
    }

    public static void InternalIncrement(Counter counter, int n)
    {
        for(int i=0; i<n; i++)
        {
            counter.Increment();
        }
    }

}