namespace Lekce_02_Ukol01
{
    class Kalkulacka
    {
        public double vysledek;
        public double desetinneCislo;

        public double Secti(double a, double b)
        {
            vysledek = a + b;
            return vysledek;
        }

        public double NactiDesetinneCisloZKonzole(string textOdUzivatele)
        {
            while (true)
            {
                bool jeCisloPlatne = double.TryParse(textOdUzivatele, out desetinneCislo);

                if (jeCisloPlatne)
                {
                    break;
                }
                else
                {
                    Console.Write("Zadal jsi neplatné číslo, zkus to znovu: ");
                    textOdUzivatele = Console.ReadLine();
                }
            }
            return desetinneCislo;
        }
    }
}
