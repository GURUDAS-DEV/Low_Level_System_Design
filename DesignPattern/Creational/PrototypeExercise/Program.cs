class Program
{
    public static void Main()
    {
        Rectangle rectangle1 = new Rectangle("Black", 10, 20);
        Circle OriginalCircle = new Circle("Black", 11);

        var ClonedCircle = (Circle)OriginalCircle.Clone();
        ClonedCircle.Color = "Red";

        Console.WriteLine("Color of Original Circle : " + OriginalCircle.Color);
        Console.WriteLine("Color of Cloned Circle : " + ClonedCircle.Color);
        Console.WriteLine("Radius of Cloned Circle : " + ClonedCircle.Radius);
    }
}