namespace Lekce_02_Vyjimky
{
    public class BezpecneDeleni
    {
        public double PodelCisla(double a, double b)
        {
            // když mi uživatel dá b = 0, tak si s tím neumím poradit
            // chci, aby to skončilo chybou

            if (b == 0.0)
            {
                throw new ArgumentException("Nulou nelze dělit");
            }

            return a / b;
        }
    }
}
