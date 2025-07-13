namespace OOApp.Model;

/// <summary>
/// POCO class - Plain Old CLR Object
/// </summary>
public sealed class ImmuTeacher
{
    public int Id { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init;  }
    
    public ImmuTeacher () { }

    public ImmuTeacher(int id, string? firstName, string? lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
}