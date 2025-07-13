namespace AbstractClassesApp.Model;

public class Cat : AbstractAnimal
{
    public override string ToString()
    {
        return "Id: " + Id + ", Name: " + Name + ", Age: " + Age;
    }

    public override void Eat()
    {
        Console.WriteLine("Cat is eating");
    }

    public override void Speak()
    {
        Console.WriteLine("Cat says hello");
    }
}