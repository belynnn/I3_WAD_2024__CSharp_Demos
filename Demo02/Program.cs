namespace Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coucou toi !");
            Console.WriteLine("C'est quoi ton p'tit nom ?");

            string? userFirstname = Console.ReadLine();
            
            Console.Clear();
            
            Console.WriteLine($"Bonjour {userFirstname} !\nIl est {DateTime.Now.ToShortTimeString()}.");
        }
    }
}
