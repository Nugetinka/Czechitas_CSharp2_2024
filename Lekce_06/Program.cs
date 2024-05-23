namespace Lekce_06
{
    public class Rytir
    {
        public string Jmeno { get; private set; }  // fieldy můžeme psát buď velkým písmem na začátku nebo s "_" na začátku
        public int Sila;

        public static int PocetRytiru;

        private int pomocnaZdravi;
        public int Zdravi // rozšířený zápis
        {
            get
            {
                return pomocnaZdravi;
            }
            private set
            {
                if (value < 0) // klíčové slovo "value" se musí použít
                {
                    pomocnaZdravi = 0;
                }
                else
                {
                    pomocnaZdravi = value;
                }
                //zdravi = value < 0 ? 0 : value;  // ternární zápis, jinak zapsaný if/else
            }
        }

        public bool JeZivy
        {
            get
            {
                return Zdravi > 0;
            }
        }

        public Rytir(string jmeno, int sila, int zdravi)
        {
            Console.WriteLine("Toto je plný konstruktor");
            Jmeno = jmeno;
            Sila = sila;
            Zdravi = zdravi;
            PocetRytiru++;
        }

        public Rytir(string jmeno)
        {
            Jmeno = jmeno;
            Sila = 20;
            Zdravi = 100;
            PocetRytiru++;
        }

        //public Rytir(string jmeno, int sila = 30)
        //{
        //    Jmeno = jmeno;
        //}

        public Rytir(string jmeno, int sila) : this(jmeno, sila, 250)
        {
            Console.WriteLine("Toto je zůžený konstruktor");
        }

        private int VratSiluUderu()
        {
            return Sila;
        }

        //private int VratZbyvajiciZdravi(int silaUtoku)
        //{
        //    return silaUtoku;
        //}

        public void UtocNaRytire(Rytir protivnik)
        {
            Zdravi -= protivnik.VratSiluUderu();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rytir borivoj = new Rytir("Bořivoj", 10, 100);
            Rytir bonifac = new Rytir("Bonifác");
            Rytir geralt = new Rytir("Geralt", 200);

            Console.WriteLine($"Bonifácovo zdraví je {bonifac.Zdravi}");
            bonifac.UtocNaRytire(geralt);
            Console.WriteLine($"Bonifácovo zdraví je {bonifac.Zdravi}");

            Console.WriteLine($"Počet rytířů je je {Rytir.PocetRytiru}");


            //bonifac.Zdravi += 20;

            //MatematickaFunkce fce = new MatematickaFunkce();  // není zde motivace dělat další objekt, navíc je to dost obecné, můžeme z toho udělat static funkci

            MatematickaFunkce.VratSoucet(5, 4);


            RocniObdobi obdobi = RocniObdobi.Jaro;   // enum nedovolí se splést ve stringu
            RocniObdobi jineObdobi = RocniObdobi.Podzim;
            if (obdobi == RocniObdobi.Jaro)
            {
                Console.WriteLine($"Je jaro.");
            }

            switch (obdobi)
            {
                case RocniObdobi.Jaro:
                    break;
                case RocniObdobi.Zima:
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }

    public class MatematickaFunkce
    {
        public static void VratSoucet(int a, int b)  // static
        {
            Console.WriteLine($"Soucet je {a + b}");
        }
    }

    enum RocniObdobi
    {
        Jaro,
        Leto,
        Podzim,
        Zima
    }
}
