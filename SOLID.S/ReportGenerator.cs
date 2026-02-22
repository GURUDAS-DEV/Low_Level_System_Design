public class ReportGenerator
{
    private List<string[]> data = new List<string[]>()
    {
        new[] { "Name", "Sales", "Region" },
        new[] { "Alice", "15000", "North" },
        new[] { "Bob", "22000", "South" },
        new[] { "Charlie", "18000", "East" }

    };

    public List<string[]> Generate()
    {

        return data;
    }
}