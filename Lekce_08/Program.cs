namespace Lekce_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // princ, princezna, čaroděj
            // Pohádkové bytosti - bázová třída

            // 1. možnost 
            //Princezna krasomila = new Princezna();
            //Princ miroslav = new Princ();
            //Carodej cernokneznik = new Carodej();

            // 2. možnost
            PohadkovaBytost krasomila = new Princezna();
            PohadkovaBytost miroslav = new Princ();
            PohadkovaBytost cernokneznik = new Carodej();

            List<PohadkovaBytost> bytosti = new List<PohadkovaBytost> { krasomila, miroslav, cernokneznik };

            foreach(var bytost in bytosti)
            {
                bytost.PredstavSe();
            }

            // tancující pohádková bytost
            // vydávám příkaz k počátku a konci tancování
            // tohle hodí chybu kvůli čarodějovi
            //foreach(TancujiciPohadkovaBytost tpb in bytosti)
            //{
            //    tpb.ZacniTancovat();
            //    tpb.PrestanTancovat();
            //}

            // řešení, které vezme jen TancujícíPohádkovéBytosti
            foreach (TancujiciPohadkovaBytost tpb in bytosti.OfType<TancujiciPohadkovaBytost>())
            {
                tpb.ZacniTancovat();
                tpb.PrestanTancovat();
            }

            // cernokneznik.BudNeviditelny(); nejde to - nutno přetypovat
            // 1. možnost přetypování
            ((Carodej)cernokneznik).BudNeviditelny();
            ((Carodej)cernokneznik).BudViditelny();

            // 2. možnost přetypování
            (cernokneznik as Carodej).BudViditelny();
            (cernokneznik as Carodej).BudNeviditelny();

            // Tohle hodí vyjímku, volám na černokněžníkovi tancování
            //(cernokneznik as Princ).ZacniTancovat();

            // lze otestovat přímo v podmínce
            // 1. možnost otestování
            if(cernokneznik is Carodej)
            {
                (cernokneznik as Carodej).BudViditelny();
            }

            // 2. možnost otestování
            if (cernokneznik is Carodej carodej)
            {
                carodej.BudViditelny();
            }

            // 3. možnost otestování
            (cernokneznik as Carodej)?.BudViditelny();

            Console.ReadLine();
        }
    }
}
