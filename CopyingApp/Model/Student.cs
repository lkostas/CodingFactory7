namespace CopyingApp.Model;

public class Student
{
    public int Id { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public Address? Address { get; set; }

    public Student()
    {
        
    }

    public Student(int id, string? firstname, string? lastname, Address? address)
    {
        Id = id;
        Firstname = firstname;
        Lastname = lastname;
        Address = address;
    }

    public Student GetRef()
    {
        return this;
    }

    public Student GetShallowCopy()
    {
        return (Student)MemberwiseClone();
    }

    public Student GetDeepCopy()
    {
        Student student = (Student)MemberwiseClone();
        student.Address = new Address()
        {
            StreetName = Address.StreetName,
            StreetNumber = Address.StreetNumber,
            ZipCode = Address.ZipCode
        };
        return student;
    }
}