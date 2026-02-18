public class Playlist
{
    public string Name;
    private readonly List<Song> Songs = new List<Song>();

    public Playlist(string Name)
    {
        this.Name = Name; 
    }

    public void AddSong(Song SongToAdd)
    {
        Songs.Add(SongToAdd);
    }

    public void RemoveSong(Song SongToRemove)
    {
        Songs.Remove(SongToRemove);
    }

    public int GetTotalDuration()
    {
        int TotalDuration = 0;
        foreach (var s in Songs)
        {
            TotalDuration += s.GetDuration();
        }

        return TotalDuration;
    }
}