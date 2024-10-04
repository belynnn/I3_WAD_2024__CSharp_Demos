namespace Demo03bis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Méthode Parse
            /*
            Console.WriteLine("Quel jour sommes-nous ?");

            string userAnswer = Console.ReadLine();

            int dayInMonth = int.Parse(userAnswer);

            Console.WriteLine($"Il reste donc +/- {31 - dayInMonth} jours dans le mois");
            */

            // Méthode Tryparse
            Console.WriteLine("Quel jour sommes-nous ?");

            string userAnswer = Console.ReadLine();

            int dayInMonth;
            bool isConverted;

            isConverted = int.TryParse(userAnswer, out dayInMonth);

            Console.WriteLine($"Conversion réussie ? {isConverted}.");
            Console.WriteLine($"Il reste donc +/- {31 - dayInMonth} jours dans le mois");
        }
    }
}
