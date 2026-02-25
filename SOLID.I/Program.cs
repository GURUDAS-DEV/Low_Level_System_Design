class Program
{
    public static void Main()
    {
        BasicPrinter basicPrinter = new BasicPrinter();
        basicPrinter.Print("This is Document Printed Through Basic Printer");

        OfficePrinter officePrinter = new OfficePrinter();
        officePrinter.Print("This is Document Printed Through Office Printer");
        officePrinter.Scan("This is Document Scanned Through Office Printer");
        officePrinter.Fax("This is Document Fax Through Office Printer");

        FullDevice fullDevice = new FullDevice();
        fullDevice.Print("This is Document Printed Through Full Printer");
        fullDevice.Scan("This is Document Scanned Through Full Printer");
        fullDevice.Fax("This is Document Faxing Through Full Printer");
        fullDevice.Staple("This is Document Stapling Through Full Printer");

        
    }
}