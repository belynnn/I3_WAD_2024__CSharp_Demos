namespace Demo04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez, s'il vous plait, introduire votre année de naissance :");
            string userInput = Console.ReadLine();
            int userBirthYear;
            bool isConverted = int.TryParse(userInput, out userBirthYear);
            if (isConverted)
            {
                int yearsOld = DateTime.Now.Year - userBirthYear;
                if (yearsOld >= 18)
                {
                    Console.WriteLine("Veuillez indiquer votre pays de résidence :");
                    string country = Console.ReadLine();
                    if (country.ToLower() == "belgique")
                    {
                        Console.WriteLine("Bienvenue sur le site de la loterie nationale, une fois!");
                    }
                    else if (country.ToLower() == "france")
                    {
                        Console.WriteLine("Bienvenue sur le site de la loterie nationale, cocorico.");
                    }
                    else if (country.ToLower() == "suisse")
                    {
                        Console.WriteLine("Bienvenueuh sur le siteuh de la loterieuh nationaleuh.");
                    }
                    else if (country.ToLower() == "canada")
                    {
                        Console.WriteLine("bienvenue sur le site de la loterie nationale, tabernac.");
                    }
                    else
                    {
                        Console.WriteLine("Votre pays de résidence n'est pas présent sur la liste des pays francophone.");
                    }
                }
                else
                {
                    Console.WriteLine($"Reviens dans {18 - yearsOld} ans !");
                }
            }
            else
            {
                Console.WriteLine("Entrée invalide...");
            }
        }
    }
}