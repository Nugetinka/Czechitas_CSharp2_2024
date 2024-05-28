namespace Lekce_02_Ukol01
{
    class Kalkulacka
    {
        public double Secti(double a, double b)
        {
            return a + b;
        }

        public double NactiDesetinneCisloZKonzole()
        {
            double desetinneCislo;

            while (true)
            {
                string textOdUzivatele = Console.ReadLine();
                bool jeCisloPlatne = double.TryParse(textOdUzivatele, out desetinneCislo);

                if (jeCisloPlatne)
                {
                    break;
                }
                else
                {
                    Console.Write("Zadal jsi neplatné číslo, zkus to znovu: ");
                }
            }
            return desetinneCislo;
        }
    }
}
