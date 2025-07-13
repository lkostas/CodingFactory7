using StackApp.Exceptions;

namespace StackApp.Model;

public class CFStack
{
    public int[] Stack { get; set; } = new int[100];
    public int Top { get; set; }
    public int Size { get; set; }

    public CFStack()
    {
        Size = 100;
        Stack = new int[100];
        Top = -1;
    }

    public CFStack(int size)
    {
        Size = size;
        Stack = new int[size];
        Top = -1;
    }

    public bool isFull()
    {
        return Top == Size - 1;
    }

    public bool isEmpty()
    {
        return Top == -1;
    }

    public void Push(int num)
    {
        if (isFull())
        {
            throw new StackIsFullException("Error. Stack is full");
        }
        Stack[++Top] = num;
    }

    public int Pop()
    {
        if (isEmpty())
        {
            throw new StackIsEmptyException("Error. Stack is empty");
        }
        return Stack[Top--];
    }

    public void Traverse()
    {
        for (int i = 0; i <= Top; i++)
        {
            Console.Write(Stack[i] + " ");
        }
    }
}