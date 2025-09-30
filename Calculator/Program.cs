namespace Calculator
{
    internal class Program
    {
        /// <summary>
        /// Funktio yhteenlaskulle
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Sum(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Funktio vähennyslaskulle
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Funktio kertolaskulle
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Funktio jakolaskulle
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Divide(double a, double b)
        {
            if (b == 0 || a == 0)
            {
                Console.WriteLine("Virhe: Nollalla ei voi jakaa!");
                return 0;
            }
            return a / b;
        }

        //Main koodi
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
            string op;

            //valitaan lasku tyyppi
            switch (valinta)
            {
                case 1:
                    tulos = Sum(luku1, luku2);
                    op = "+";
                    break;
                case 2:
                    tulos = Subtract(luku1, luku2);
                    op = "-";
                    break;
                case 3:
                    tulos = Multiply(luku1, luku2);
                    op = "*";
                    break;
                case 4:
                    tulos = Divide(luku1, luku2);
                    op = "/";
                    break;
                default:
                    Console.WriteLine("Virheellinen valinta!");
                    return;
            }

            NewMethod(luku1, luku2, tulos, op);
        }
        /// <summary>
        /// tuloksen kertominen ja erikseen laitettu koodin siisteyden takia
        /// </summary>
        /// <param name="luku1"></param>
        /// <param name="luku2"></param>
        /// <param name="tulos"></param>
        /// <param name="op"></param>
        private static void NewMethod(double luku1, double luku2, double tulos, string op)
        {
            Console.WriteLine($"Tulos: {luku1} {op} {luku2} = {tulos}");
        }
    }
}