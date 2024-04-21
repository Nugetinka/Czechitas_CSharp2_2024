namespace Lekce_02_Vyjimky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cislo1 = 10.0;
            double cislo2 = 0.0;

            //int cislo1 = 10;
            //int cislo2 = 0;

            //Console.WriteLine($"Výsledek dělení je {cislo1 / cislo2}");

            BezpecneDeleni podel = new BezpecneDeleni();

            try
            {
                podel.PodelCisla(cislo1, cislo2);
            }
            catch (Exception vyjimka)
            {
                Console.WriteLine(vyjimka);
                Console.ReadLine();
            }
        }

        private static void Vyjimky()
        {
            // uživatel zadá dva integery a nechá si je vydělit
            Console.WriteLine("Zadej první číslo: ");
            string vstup = Console.ReadLine();

            int cislo1 = 0;
            try
            {
                cislo1 = int.Parse(vstup);
            }
            catch (OverflowException vyjimka)  // catch (Exception vyjimka)
            {
                //Console.WriteLine("Nezadal jsi správný vstup.");
                //Console.WriteLine("Ukončuji program.");

                Console.WriteLine("Cislo je moc velké");   //Console.WriteLine(vyjimka); -> delší message
                Console.ReadLine();
                return;
            }
            catch (FormatException vyjimka)
            {
                Console.WriteLine("Zadal jsi špatný formát čísla.");
                Console.ReadLine();
                return;
            }
            catch (Exception vyjimka)
            {
                Console.WriteLine(vyjimka.Message);
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Zadej druhé číslo: ");
            vstup = Console.ReadLine();
            int cislo2 = int.Parse(vstup);

            Console.WriteLine($"Výsledek dělení je {cislo1 / cislo2}");
        }
    }
}
