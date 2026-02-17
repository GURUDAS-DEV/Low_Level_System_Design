public class Room
{
    public string RoomId{get;}
    public int Floor {get;}

    public Room(string RoomId, int Floor)
    {
        this.RoomId = RoomId;
        this.Floor = Floor;
    }

}