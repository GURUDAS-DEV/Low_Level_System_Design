using System;

class SeatValidator
{
    public bool IsAvailable(string eventId, string seatNumber)
    {
        Console.WriteLine($"Checking seat {seatNumber} for event {eventId}");
        return true; // Simulated: seat is available
    }
}

class PaymentProcessor
{
    public bool Charge(string email, double amount)
    {
        Console.WriteLine($"Charging ${amount} to {email}");
        return true; // Simulated: payment succeeds
    }
}

class QRCodeGenerator
{
    public string Generate(string eventId, string seatNumber)
    {
        string qrCode = $"QR-{eventId}-{seatNumber}";
        Console.WriteLine($"Generated QR code: {qrCode}");
        return qrCode;
    }
}

class EmailService
{
    public void SendConfirmation(string email, string qrCode)
    {
        Console.WriteLine($"Sending confirmation to {email} with code {qrCode}");
    }
}

class TicketBookingService
{
    public bool BookTicket(string eventId, string seatNumber, string email,
                           double amount, SeatValidator validator,
                           PaymentProcessor payment, QRCodeGenerator qrGenerator,
                           EmailService emailService)
    {
        if (!validator.IsAvailable(eventId, seatNumber))
        {
            Console.WriteLine("Seat not available.");
            return false;
        }

        if (!payment.Charge(email, amount))
        {
            Console.WriteLine("Payment failed.");
            return false;
        }

        string qrCode = qrGenerator.Generate(eventId, seatNumber);
        emailService.SendConfirmation(email, qrCode);

        Console.WriteLine("Booking confirmed!");
        return true;
    }
}

class Program
{
    static void Main()
    {
        var bookingService = new TicketBookingService();

        // All dependencies are created externally and passed in
        var validator = new SeatValidator();
        var payment = new PaymentProcessor();
        var qrGenerator = new QRCodeGenerator();
        var emailService = new EmailService();

        bookingService.BookTicket("CONF-2026", "A12", "Gurudas@gmail.com",
            929.99, validator, payment, qrGenerator, emailService);
    }
}