
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
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? ID { get; set; }
        public int YearRegistration { get; set; }
        public string Denomination
        {
            get
            {
                return ID + ' ' + Name + ' ' + LastName;
            }
        }

    }
    public class Organization : IUser
    {
        public string? CompanyName { get; set; }
        public string? ID { get; set; }
        public int YearRegistration { get; set; }
        public string Denomination
        {
            get
            {
                return ID + ' ' + CompanyName;
            }
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