namespace Lekce_04_Slovniky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Slovnik - DICTIONARY<key, value>

            Dictionary<string, string> slovnikAj = new Dictionary<string, string>
            {
                { "ahoj", "hello" },
                { "auto", "car" },
                { "dům", "house" }
            };

            slovnikAj.Add("květina", "flower");

            Console.WriteLine($"Květina je anglicky {slovnikAj["květina"]}.");

            Console.WriteLine();

            foreach (KeyValuePair<string, string> zaznam in slovnikAj) // vrací se dvojice objektů - místo KeyValuePair mohu použít var
            {
                Console.WriteLine($"{zaznam.Key} : {zaznam.Value}");
            }

            //foreach (var zaznam in slovnikAj) // vrací se dvojice objektů - místo KeyValuePair mohu použít var
            //{
            //    Console.WriteLine($"{zaznam.Key} : {zaznam.Value}");
            //}

            if(!slovnikAj.ContainsKey("auto"))  // vrací bool
            {
                slovnikAj.Add("auto", "car");
            }
            else
            {
                Console.WriteLine("Záznam už tam je.");
            }

            // TryGetValue
            string anglickyPreklad;
            if(slovnikAj.TryGetValue("ahoj", out anglickyPreklad))
            {
                Console.WriteLine($"Překlad ahoj je {anglickyPreklad}.");
            }
            else
            {
                Console.WriteLine("Takové slovíčko tam není.");
            }

            slovnikAj.Remove("auto");

            slovnikAj.Clear();

            slovnikAj["auto"] = "vehicle";
        }
    }
}
