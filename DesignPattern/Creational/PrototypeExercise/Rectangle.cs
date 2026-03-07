class Rectangle : ICloneable
{
    public string Color{get; set;}
    public int Width{get; set;}
    public int Height{get; set;}

    public Rectangle(string Color, int Width, int Height)
    {
        this.Color = Color;
        this.Width = Width;
        this.Height = Height;
    }

    public ICloneable Clone()
    {
        return new Rectangle(Color, Width, Height);
    }
}