namespace Demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;

            Console.WriteLine(today.ToString());
            Console.WriteLine(today.ToString("dd MMMM yyyy"));
        }
    }
}
