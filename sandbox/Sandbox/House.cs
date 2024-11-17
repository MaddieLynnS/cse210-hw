public class House
{
    private List<Room> _rooms = new List<Room>();

    public void AddRoom(Room room)
    {
        _rooms.Add(room);
    }
}