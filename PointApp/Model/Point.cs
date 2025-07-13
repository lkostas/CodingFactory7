namespace PointApp.Model;

public class Point
{
    public int X { get; set; }

    public Point()
    {
        
    }

    public Point(int x)
    {
        X = x;
    }

    public override string? ToString()
    {
        return $"{{{X}}}";
    }

    public static Point GetOnePoint()
    {
        return new Point();
    }

    public virtual void Move10()
    {
        X += 10;
    }
}