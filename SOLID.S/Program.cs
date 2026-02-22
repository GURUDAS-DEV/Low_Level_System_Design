using System.Text;

// TODO: Refactor into ReportGenerator, ReportFormatter, and ReportDistributor.

class Program
{
    static void Main()
    {
        // After refactoring, usage should look like:
        var generator = new ReportGenerator();
        var formatter = new ReportFormatter();
        var distributor = new ReportDistributor();
        var data = generator.Generate();
        var formatted = formatter.FormatAsCsv(data);
        distributor.Distribute("manager@company.com", formatted);
    }
}