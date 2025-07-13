namespace CollectionsApp;

class Program
{
    static void Main(string[] args)
    {
        var intList = new List<int>() { 1, 2, 3, 4, 5 };
        var LinkedList = new LinkedList<string?>();
        var words = new SortedDictionary<int, string>() {{1, "AUEB" } , {2, "OPA "}};
        var stack = new Stack<string>();
        var queue = new Queue<string>();
        var charset = new SortedSet<char>() {'a' , 'b', 'c' };
        
        intList.Add(4);
        intList.AddRange([ 1, 2, 3]);
        intList.Add(5);
        intList.Insert(0, 5);
        intList.RemoveAt(0);
        intList[0] = 3;
        intList[1] = 4;
        
        intList.Sort();
        intList.Reverse();

        foreach (int el in intList)
        {
            Console.WriteLine(el);
        }
        
        intList.ForEach(x => Console.WriteLine(x));
        intList.ForEach(Console.WriteLine);
        
        /*
         * Linked List 
         */

        var item1 = LinkedList.AddFirst("Coding");
        var item2 = LinkedList.AddAfter(item1, "Factory");
        var item3 = LinkedList.AddLast("AUEB");
        
        LinkedList.First!.Next!.Next!.Value = "Athens Uni of Econ and Bus";

        foreach (var el in LinkedList)
        {
            Console.WriteLine(el);
        }
        
        LinkedList.ToList().ForEach(x => Console.WriteLine(x));
        LinkedList.ToList().ForEach(Console.WriteLine);
        
        
        // Dictionarys
        words.Add(1, "Athens");
        words[2] = "Uni";
        words[3] = "Economics";

        words.Remove(1);

        if (words.ContainsKey(4))
        {
            Console.WriteLine("Contains 4");
        }
        else
        {
            words[4] = "Business";
        }

        foreach (var keyval in words)
        {
            Console.WriteLine($"{keyval.Key}, {keyval.Value}");
        }
        
        words.ToList().ForEach(x => Console.WriteLine(x.Key + ", " + x.Value));
        
        /*
         * Sets
         */
        var charset2 = new SortedSet<char>() {'!', '@'};
        charset.Add('x');
        charset.Remove('a');
        
        charset.UnionWith(charset2);

        foreach (var ch in charset)
        {
            Console.WriteLine(ch + "");
        }
        
        /*
         * Stack: push & pop
         */
        stack.Push("Hello");
        stack.Push("World");
        string popped = stack.Pop();    // World
        Console.WriteLine(popped);

        foreach (var el in stack)
        {
            Console.WriteLine(el);
        }
        
        /*
         * Queue
         */
        queue.Enqueue("car1");
        queue.Enqueue("car2");
        queue.Enqueue("car3");
        string car1 = queue.Dequeue();  // car1

        foreach (var car in queue)
        {
            Console.WriteLine(car);
        }
    }
}