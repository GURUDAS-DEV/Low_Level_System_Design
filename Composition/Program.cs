public class Program
{

    public static void Main()
    {
        House MyHouse = new House("MeraGhar");
        Room Kitchen = new Room("Kitchen", "100sq. Km");
        Room Bathroom = new Room("Bathroom", "110sq. Km");
        Room Dinning_Room = new Room("Dinning_Room", "130sq. Km");

        MyHouse.AddRooms(Kitchen);
        MyHouse.AddRooms(Bathroom);
        MyHouse.AddRooms(Dinning_Room);
    }

}