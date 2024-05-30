namespace Lekce_08_BR02
{
    public class Kruh : IUmiPocitatObsah, IUmiPocitatObvod
    {
        private double _polomer;

        public Kruh(double polomer)
        {
            _polomer = polomer;
        }

        public double SpocitejObsah()
        {
            return Math.PI * _polomer;
        }

        public double SpocitejObvod()
        {
            return 2 * Math.PI * _polomer * _polomer;
        }
    }
}
