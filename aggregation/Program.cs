public class Program
{
    public static void Main()
    {
        Song s1 = new Song("Pal Pal", "Talwinder", 250);
        Song s2 = new Song("Pal Pal Dil Ke pass", "Kishore Kumar", 350);
        Song s3 = new Song("OO Mere Sapno Ki Rani", "Kishore Kumar", 150);
        Song s4 = new Song("Hoto se chu lu Toh", "Mohamad Rafi", 450);

        Playlist myPlaylist = new Playlist("MyPlaylist");
        myPlaylist.AddSong(s1);
        myPlaylist.AddSong(s2);
        myPlaylist.AddSong(s3);
        myPlaylist.AddSong(s4);

        Console.Write(myPlaylist.GetTotalDuration());
    }
}