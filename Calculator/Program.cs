namespace Calculator
{
    internal class Program
    {
        // Funktio yhteenlaskulle
        static double Sum(double a, double b)
        {
            return a + b;
        }

        // Funktio vähennyslaskulle
        static double Subtract(double a, double b)
        {
            return a - b;
        }

        // Funktio kertolaskulle
        static double Multiply(double a, double b)
        {
            return a * b;
        }

        // Funktio jakolaskulle
        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Virhe: Nollalla ei voi jakaa!");
                return 0;
            }
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Yksinkertainen laskin ===");

            Console.Write("Anna ensimmäinen luku: ");
            double luku1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Anna toinen luku: ");
            double luku2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valitse toiminto:");
            Console.WriteLine("1 - Yhteenlasku");
            Console.WriteLine("2 - Vähennyslasku");
            Console.WriteLine("3 - Kertolasku");
            Console.WriteLine("4 - Jakolasku");
            Console.Write("Valinta: ");
            int valinta = Convert.ToInt32(Console.ReadLine());

            double tulos = 0;

            switch (valinta)
            {
                case 1:
                    tulos = Sum(luku1, luku2);
                    break;
                case 2:
                    tulos = Subtract(luku1, luku2);
                    break;
                case 3:
                    tulos = Multiply(luku1, luku2);
                    break;
                case 4:
                    tulos = Divide(luku1, luku2);
                    break;
                default:
                    Console.WriteLine("Virheellinen valinta!");
                    return;
            }

            Console.WriteLine($"Tulos: {tulos}");
        }
    }
}