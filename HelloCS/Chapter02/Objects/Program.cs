using System.Drawing;
using System.Xml.Linq;

namespace Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Normaly, types are created with its defaults
            short age; // default 0
            long sizeOfCountry; //default 0
            DateTime someDate; // default 0001-01-01
            Point location;//?
            Person bob; // null


            // Since we already defined the types we can then asign values to the variables like

            age = 43;
            sizeOfCountry = 50_000;

            // And only use new when we want different values from their original defined ones
            someDate = new(2000, 5, 10); // Since the type was already defined, we didn't needed to write new DateTime(...)
            bob = new("Bob", "Surname", someDate.Year);

            Person kim = new();
            kim.BirthDate = new(2001, 4, 4);

            List<Person> people = new() // Instead of: new List<Person>()
             {
              new() { Name = "Alice" }, // Instead of: new Person() { ... }
              new() { Name = "Bob" },
              new() { Name = "Charlie" }
             };

            Console.WriteLine($"default(int) = {default(int)}"); // will be 0
            Console.WriteLine($"default(bool) = {default(bool)}"); // will be false
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");//will be 01/01/0001 00:00:00
            Console.WriteLine($"default(string) = {default(string) ?? "<NULL>"}"); // And since string is a reference type, string per se is NULL
        }
    }
}
