class RenderedCharacter
{
    private readonly ICharacterFlyweight glyph;
    private readonly int x, y;

    public RenderedCharacter(ICharacterFlyweight glyph, int x, int y)
    {
        this.glyph = glyph;
        this.x = x;
        this.y = y;
    }

    public void Render()
    {
        glyph.Draw(x, y);
    }
}

class TextEditorClient
{
    private readonly CharacterFlyweightFactory factory = new CharacterFlyweightFactory();
    private readonly List<RenderedCharacter> document = new List<RenderedCharacter>();

    public void AddCharacter(char c, int x, int y, string font, int size, string color)
    {
        ICharacterFlyweight glyph = factory.GetFlyweight(c, font, size, color);
        document.Add(new RenderedCharacter(glyph, x, y));
    }

    public void RenderDocument()
    {
        foreach (RenderedCharacter rc in document)
        {
            rc.Render();
        }
        Console.WriteLine($"Total flyweight objects used: {factory.GetFlyweightCount()}");
    }
}