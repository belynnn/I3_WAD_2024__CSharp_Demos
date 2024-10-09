namespace Demo05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dans quel pays résidez-vous ? :");
            string country = Console.ReadLine();

            /*
            string resident = (country.ToLower() == "belgique") ? "belge" :
                                (country.ToLower() == "france") ? "français(e)" :
                                (country.ToLower() == "suisse") ? "suisse" : "autre";
            */

            string resident = country.ToLower() switch
            {
                "belgique" => "belge",
                "france" => "français(e)",
                "suisse" => "suisse",
                _ => "autre"
            };

            Console.WriteLine("Quel âge avez-vous ?");
			string userInput = Console.ReadLine();
			int yearsOld = int.Parse(userInput);
			Console.WriteLine($"Vous êtes {resident} et êtes âgé de {yearsOld} an{((yearsOld > 1)? "s" : "")}.");
        }
    }
}
