class Program
{
    public static void Main()
    {
        var email1 = new Email.Builder("gurudas@gmail.com", "This is my Subject")
                        .SetBody("This is Body")
                        .SetCC("123")
                        .SetPriority("1")
                        .SetBCC("BCC")
                        .SetAttachment("This is attachment")
                        .Build();

        Console.WriteLine(email1);
    }
}