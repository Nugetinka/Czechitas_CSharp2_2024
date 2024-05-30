namespace Lekce_08_BR02
{
    public class Obdelnik : IUmiPocitatObsah, IUmiPocitatObvod
    {
        private double _vyska;
        private double _sirka;

        public Obdelnik(double vyska, double sirka)
        {
            _vyska = vyska;
            _sirka = sirka;
        }

        public double SpocitejObsah()
        {
            return _vyska * _sirka;
        }

        public double SpocitejObvod()
        {
            return 2 * (_sirka + _vyska);
        }
    }
}
