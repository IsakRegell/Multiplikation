namespace Multiplikation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett nummer");
            int siffran = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{siffran} * {i} = {siffran * i}");
            }
            
        }
    }
}
