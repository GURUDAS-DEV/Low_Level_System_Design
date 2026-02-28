class Program
{
    public static void Main()
    {
        var post = new HTTPRequest.Builder("https://product.com/user")
            .SetBody("Nothing To Send")
            .SetHeaders("Content-Type", "application/json")
            .SetTimeout(3000)
            .SetMethod("POST")
            .SetQueryParameter("Product", "1")
            .Build();

        Console.WriteLine(" ");
        Console.WriteLine(post);
        Console.WriteLine(" ");
    }
}