namespace FileManagement.Model;

public class GenericNode<T>
{
    public T? Value { get; set; }
    public int Count { get; set; }
    public GenericNode<T>? Next { get; set; }
    public GenericNode<T>? Prev { get; set; }
}