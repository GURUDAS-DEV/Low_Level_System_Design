// class Program
// {
//     public static void Main()
//     {
//         OrderProcessor Process = new OrderProcessor(new EUTaxCalculator());
//         Process.ProcessOrder("O123", 100);
//         OrderProcessor Process1 = new OrderProcessor(new UKTaxCalculator());
//         Process1.ProcessOrder("O123", 150);
//         OrderProcessor Process2 = new OrderProcessor(new USTaxCalculator());
//         Process2.ProcessOrder("O123", 900);
//     }
// }       

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    public static TimeSpan GetLongestTimeGap(List<string> timestamps)
    {
        int n = timestamps.Count;
        if(n < 2)
            return TimeSpan.Zero;
            
            
        List<DateTime> times = new List<DateTime>();
        foreach (var t in timestamps)
        {
            times.Add(DateTime.Parse(t));
        }

        // Sort the times
        times.Sort();

        TimeSpan longestGap = TimeSpan.Zero;

        // Compare consecutive timestamps
        for (int i = 1; i < times.Count; i++)
        {
            TimeSpan gap = times[i] - times[i - 1];

            if (gap > longestGap)
                longestGap = gap;
            
        }

        return longestGap;

    }
    public static void Main()
    {
        List<string> timestamps = new List<string>{"2026-03-15T10:00:00Z", "2026-03-15T10:45:00Z", "2026-03-15T12:30:00Z", "2026-03-15T13:00:00Z"};//i have generated these timestamp from ai, other wise whole code is written by me, because i don't know how to write manually these timestamps.
        
        TimeSpan LongestGap = GetLongestTimeGap(timestamps);

        Console.WriteLine("The Longest Time Span we get is : " + LongestGap);
    }
}