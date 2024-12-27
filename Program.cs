public interface IUser
{
    string ID { get; set; }
    int YearRegistration { get; set; }

    string Denomination { get; }
}

public class Person : IUser
{
    string? Name { get; set; }
    string? LastName { get; set; }
    string? ID { get; set; }
    int YearRegistration { get; set; }
    public string Denomination()
    {
        return ID + Name + LastName;
    }
}