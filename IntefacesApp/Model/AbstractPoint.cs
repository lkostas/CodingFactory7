using IntefacesApp.Model;

namespace IntefacesApp.Model;

public abstract class AbstractPoint : IMoveable
{
    public int X { get; set; }

    public AbstractPoint()
    {
        
    }

    protected AbstractPoint(int x)
    {
        X = x;
    }

    public virtual void Move10()
    {
        X += 10;
        Console.WriteLine("Move by 10");
    }

    public virtual void Move15()
    {
        X += 15;
        Console.WriteLine("Move by 15");
    }
}