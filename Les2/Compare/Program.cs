namespace Compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = 0;
            int x2 = 2;

            List<int> numbers = new List<int>() { 4, 3, 5, 7, 2, 4, 6 };

            PrintList(numbers);
            numbers.Sort();
            PrintList(numbers);


            List<Persoon> personen = new List<Persoon>()
            {
                new Persoon() { Familienaam = "Doe", Voornaam="John" },
                new Persoon() { Familienaam = "Doe", Voornaam="Jane" },
                new Persoon() { Familienaam = "Travolta", Voornaam="John" },
                new Persoon() { Familienaam = "Maximus", Voornaam="Max" },
            };

            PrintList(personen);

            personen.Sort();

            PrintList(personen);


        }
        static void PrintList(List<Persoon> personen)
        {
            foreach (Persoon item in personen)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        static void PrintList(List<int> numbers)
        {
            foreach (int item in numbers)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
