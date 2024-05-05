namespace Lekce_04_BR02
{
    internal class Program
    {
        static void Main()
        {
            TelefonniSeznam telefonniSeznam = new TelefonniSeznam();

            telefonniSeznam.VypisVse();
            Console.WriteLine("-----------------------");

            telefonniSeznam.NovyZaznam("Josef", 777555666);
            telefonniSeznam.VypisVse();
            Console.WriteLine("-----------------------");

            Console.WriteLine(telefonniSeznam.VratTelefonniCislo("Kiki"));
            Console.WriteLine("-----------------------");

            telefonniSeznam.SmazZaznam("Lucka");
            telefonniSeznam.VypisVse();
            Console.WriteLine("-----------------------");

            telefonniSeznam.SmazTelefonniSeznam();
            telefonniSeznam.VypisVse();
            Console.WriteLine("-----------------------");
        }
    }
}

/* Vytvorte tridu TelefonniSeznam
- uvnitr ni budete ukladat dvojice Jmeno - Telefonni cislo
- k tomu pouzijte Dictionary, jehoz klice budou stringy a hodnoty integery
- v ramci konstruktoru vyplnte nekolik jmen a cisel
- vytvorte metodu, ktera do slovniku ulozi noveho cloveka a jeho telefonni cislo
- vytvorte metodu, ktera vrati telefonni cislo cloveka
- vytvorte metodu, ktera vypise cely telefonni seznam
- vytvorte metodu, ktera smaze daneho cloveka
- vytvorte metodu, ktera smaze cely telefonni seznam .Clear()
- myslete na mozne chybove stavy (co kdyz tam dany clovek neni, co kdyz pridavam cloveka, ktery uz tam je)
- napiste kratky program, ktery overi funkcnost teto tridy */

