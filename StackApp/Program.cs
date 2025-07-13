﻿using StackApp.Exceptions;
using StackApp.Model;
namespace StackApp;

class Program
{
    static void Main(string[] args)
    {
        CFStack myStack = new();

        try
        {
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            int poppeed = myStack.Pop();
            Console.WriteLine($"Poppeed: {poppeed}");

            myStack.Traverse();
        }
        catch (StackIsEmptyException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (StackIsFullException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}