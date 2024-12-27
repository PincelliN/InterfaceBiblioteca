
namespace Biblio
{

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
    public class Organization : IUser
    {
        string? CompanyName { get; set; }
        string? ID { get; set; }
        int YearRegistration { get; set; }
        public string Denomination()
        {
            return ID + CompanyName;
        }
    }

    public class Library
    {
        static Array Users;

        static void List()
        {
            Console.WriteLine($"{Users}");

        }
        public void Main()
        {
            Persona a = new Persona("Nicolò", "Pincelli", 001);
            Organization b = new Organization("Freelance", 001);

        }
    }
}