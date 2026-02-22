using System.Text;

public class ReportFormatter
{
    public StringBuilder FormatAsCsv(List<string[]> data)
    {
        StringBuilder csv = new StringBuilder();
        foreach (var row in data)
        {
            csv.AppendLine(string.Join(",", row));
        }
        return csv;
    }  
}