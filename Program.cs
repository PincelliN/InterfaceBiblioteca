namespace Biblio
{
    // Interfaccia IUser che definisce le proprietà comuni per gli utenti 
    public interface IUser
    {
        string ID { get; set; }
        int YearRegistration { get; set; }
        string Denomination { get; }
    }

    // Classe Person che implementa l'interfaccia IUser
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
                return $"{ID} {Name} {LastName}";
            }
        }
    }

    // Classe Organization che implementa l'interfaccia IUser
    public class Organization : IUser
    {
        public string? CompanyName { get; set; }
        public string? ID { get; set; }
        public int YearRegistration { get; set; }
        public string Denomination
        {
            get
            {
                return $"{ID} {CompanyName}";
            }
        }
    }

    public class Library
    {
        // Array di IUser per contenere sia persone che organizzazioni
        static IUser[] Users;
        static void List()
        {
            foreach (IUser item in Users)
            {
                Console.WriteLine(item.Denomination);
            }
        }
        public static void Main(string[] args)
        {
            Person a = new Person { Name = "Nicolò", LastName = "Pincelli", ID = "001", YearRegistration = 2021 };
            Organization b = new Organization { CompanyName = "Freelance", ID = "002", YearRegistration = 2024 };

            // Inizializza l'array Users con i due oggetti (una persona e un'organizzazione)
            Users = new IUser[] { a, b };
            List();
        }
    }
}
