namespace OOApp.Model;

public class Order
{
    private int _id;
    private DateTime _date;
    
    public int Id { get { return _id; } private set { _id = value; } }
    
    public DateTime Name { get { return _date; } private set { _date = value; } }
}