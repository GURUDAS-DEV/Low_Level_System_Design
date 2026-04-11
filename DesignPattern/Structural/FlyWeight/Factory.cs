class CharacterFlyweightFactory
{
    private readonly Dictionary<string, ICharacterFlyweight> flyweightMap = new Dictionary<string, ICharacterFlyweight>();

    public ICharacterFlyweight GetFlyweight(char symbol, string fontFamily, int fontSize, string color)
    {
        string key = symbol + fontFamily + fontSize + color;
        
        if (!flyweightMap.ContainsKey(key))
        {
            flyweightMap[key] = new CharacterGlyph(symbol, fontFamily, fontSize, color);
        }
        
        return flyweightMap[key];
    }

    public int GetFlyweightCount()
    {
        return flyweightMap.Count;
    }
}