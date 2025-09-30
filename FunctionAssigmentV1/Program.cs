using System.Xml.Linq;

namespace FunctionAssigmentV1
{
    internal class Program
    {
        /// <summary>
        /// Ask for name and ensure it is not empty
        /// </summary>
        /// <returns>if valid save and return </returns>
        static string KysyNimi ()
        {
            // Ask for name and ensure it is not empty
            while (true)
            {
                Console.Write("Enter your name: ");
                string? Input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Input))
                    return Input.Trim();

                Console.WriteLine("Name cannot be empty.");
            }
            
        }
        /// <summary>
        /// tarkistaa iän olevan positiivinen kokonaisluku
        /// </summary>
        /// <returns>Returns valid input</returns>
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
        /// <summary>
        /// Displays the specified name and age in a formatted message.
        /// </summary>
        /// <remarks>This method writes the formatted message to the console in the format: "Your name is
        /// {name} and your age is {age}."</remarks>
        /// <param name="name">The name of the individual to display. Cannot be null or empty.</param>
        /// <param name="age">The age of the individual to display. Must be a non-negative integer.</param>
        static void TulostaNimiJaIka (string name, int age)
        {
            // Print name and age
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }

        /// <summary>
        /// Determines whether the specified age qualifies as being of legal adulthood.
        /// </summary>
        /// <param name="age">The age to evaluate, in years.</param>
        /// <returns><see langword="true"/> if the age is 18 or older; otherwise, <see langword="false"/>.</returns>
        static bool TarkistaTaysiIkainen (int age)
        {
            return age >= 18;
        }

        /// <summary>
        /// Pitäisi verta nimeen toiseen nimeen
        /// </summary>
        /// <param name="name"></param>
        /// <param name="compareTo"></param>
        static void VertaaNimea (string name, string compareTo)
        {
            // Comparison ignoring case
            if (name.Equals(compareTo, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine($"Your name matches '{compareTo}' (case-insensitive).");

            // Exact match comparison (case-sensitive)
            if (name.Equals(compareTo))
                Console.WriteLine($"Your name is exactly '{compareTo}' (case-sensitive).");
        }

        static void Main(string[] args)
        {
            // Everything is intentionally inside Main before refactoring to functions
            //Your job is to refactor this code to use functions for better readability and reusability.
            //Check learn on how to do this
            string name = KysyNimi();
            int age = KysyIka ();





            TulostaNimiJaIka(name, age);
            bool isFullAge = TarkistaTaysiIkainen(age);

            // Check if the user is an adult
            if (isFullAge)
            {


                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are not an adult.");
            }
            // Compare the name to another string (e.g., "Matti")
            VertaaNimea  (name,"Matti");

            
        }
    }
}