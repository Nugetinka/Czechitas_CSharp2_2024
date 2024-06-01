namespace Lekce_08_BR02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUmiPocitatObsah obsah = new Kruh(5);
            IUmiPocitatObsah obsah1 = new Obdelnik(5, 10);

            IUmiPocitatObvod obvod = new Kruh(5);
            IUmiPocitatObvod obvod1 = new Obdelnik(5, 10);

            List<IUmiPocitatObvod> obvody = new List<IUmiPocitatObvod>
            { obvod, obvod1};

            List<IUmiPocitatObsah> obsahy = new List<IUmiPocitatObsah>
            { obsah, obsah1};

            foreach (IUmiPocitatObvod o in obvody)
            {
                Console.WriteLine(o.SpocitejObvod());
            }

            foreach (IUmiPocitatObsah o in obsahy)
            {
                Console.WriteLine(o.SpocitejObsah());
            }
        }
    }

    /*
    napiste dva ruzne interfacy: IUmiPocitatObsah, IUmiPocitatObvod
    implementujte tridy obdelnik a kruh, ktere oba interfacy pouzivaji
    vlozte jejich instance do seznamu a zavolejte na nich prislusne metody na vypocet obsahu a obvodu
    */
}
