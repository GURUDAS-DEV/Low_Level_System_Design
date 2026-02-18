public class House
{
    string Name;
    private readonly List<Room> Rooms = new List<Room>();

    public House(string Name)
    {
        this.Name = Name;
    }

    public void AddRooms(Room NewRoom)
    {
        Rooms.Add(NewRoom);
    }
}