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
                    Console.WriteLine("Bienvenue sur le site de la loterie.");
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
