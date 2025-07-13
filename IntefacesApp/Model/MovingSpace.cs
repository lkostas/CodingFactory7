namespace IntefacesApp.Model;

public class MovingSpace
{
    private readonly IMoveable? _moveable;

    public MovingSpace(IMoveable? moveable)
    {
        _moveable = moveable;
    }

    public void MakeMove15()
    {
        _moveable?.Move15();
    }
}