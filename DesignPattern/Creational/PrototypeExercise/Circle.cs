class Circle : ICloneable
{
    public string Color{get; set;}
    public int Radius{get; set;}

    public Circle(string Color, int Radius)
    {
        this.Color = Color;
        this.Radius = Radius;
    }

    public ICloneable Clone()
    {
        return new Circle(Color, Radius);
    }
}