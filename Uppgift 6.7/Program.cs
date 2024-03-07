namespace Uppgift_6._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal:");
            int tal = int.Parse(Console.ReadLine());
            if (Primtal(tal) == true)
            {
                Console.WriteLine($"{tal} är ett primtal.");
            }
            else if(Primtal(tal) == false)
            {
                Console.WriteLine($"{tal} är inte ett primtal.");
            }
            Console.ReadKey();
        }

        static bool Primtal(int tal)
        {
            if (tal < 2)
            {
                return true;
            }

            int namnare = 2;

            while (namnare * namnare <= tal)
            {
                if(tal % namnare == 0)
                {
                    return false;
                }
                namnare++;
            }
            return true;
        }
    }
}