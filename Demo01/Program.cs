namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hello les Wad!");
            Console.WriteLine("--------------");
            Console.WriteLine();
            Console.WriteLine("Aujourd'hui, nous sommes le :");

            Console.Write("Quel jour sommes-nous ? ");
            string? jour = Console.ReadLine();

            Console.Write("Quel mois ?");
            string mois = Console.ReadLine();

            Console.Write("En quelle année ?");
            string annee = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Ok, nous sommes donc le {0} {1} {2}", jour, mois, annee);

            Console.WriteLine("Veuillez appuyez sur Enter pour fermer...");
            Console.ReadLine();
        }
    }
}