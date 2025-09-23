using System.Xml.Linq;

namespace FunctionAssigmentV1
{
    internal class Program
    {
        static string KysyNimi ()
        {
            // Ask for name and ensure it is not empty
            while (true)
            {
                Console.Write("Enter your name: ");
                string? Input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Input))
                    break;
                else
                    Console.WriteLine("Name cannot be empty.");
            }
            return "";
        }
        static int KysyIka()
        {
            // Ask for age and ensure it is a positive integer
            while (true)
            {
                Console.Write("Enter your age: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int age) && age > 0)
                    return age;
                else
                    Console.WriteLine("Please enter a positive integer.");
            }
            
        }

        static void TulostaNimiJaIka (string name, int age)
        {
            // Print name and age
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }

        static bool TarkistaTaysiIkainen (int age)
        {
            return false;
        }

        static void VeraaNimea (string name, string compareTo)
        {
            // Comparison ignoring case
            if (name.Equals(compareTo, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Your name matches 'Matti' (case-insensitive).");

            // Exact match comparison (case-sensitive)
            if (name.Equals(compareTo))
                Console.WriteLine("Your name is exactly 'Matti' (case-sensitive).");
        }

        static void Main(string[] args)
        {
            // Everything is intentionally inside Main before refactoring to functions
            //Your job is to refactor this code to use functions for better readability and reusability.
            //Check learn on how to do this
            string name = "";
            int age = KysyIka ();

           

            

            

            // Check if the user is an adult
            if (age >= 18)
                Console.WriteLine("You are an adult.");
            else
                Console.WriteLine("You are not an adult.");

            // Compare the name to another string (e.g., "Matti")
            string compareName = "Matti";

            
        }
    }
}