public class Song
{
    public string Title{get;}
    public string Artist{get;}
    public int Duration{get;}

    public Song(string Title, string Artist, int Duration)
    {
        this.Title = Title;
        this.Artist = Artist;
        this.Duration = Duration;
    }

    public string GetTitle()
    {
        return Title;
    }

    public string GetArtist()
    {
        return Artist;
    }

    public int GetDuration()
    {
        return Duration;
    }
}