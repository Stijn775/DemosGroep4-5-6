namespace Les2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Console.WriteLine(Calculator.Sum(10,20));

            //Calculator calc = new Calculator();

            //Console.WriteLine(calc.Multiply(10,20));

            Persoon persoon1 = new Persoon()
            {
                Voornaam = "John",
                Familienaam = "Doe2"
            };

            Console.WriteLine(persoon1.Voornaam);
            Console.WriteLine(persoon1.Familienaam);
            
            IPersoon persoon2 = new Persoon()
            {
                Voornaam = "Jane",
                Familienaam = "Doe"
            };

            Console.WriteLine(persoon2.Familienaam);
            persoon2 = persoon1;
            Console.WriteLine(persoon2.Familienaam);

            IPersoon student = new Student()
            {
                Voornaam = "Jef",
                Familienaam = "De wit"
            };

            Console.WriteLine(student.Familienaam);


            List<IPersoon> personen = new List<IPersoon>()
            {
                student,
                persoon1,
                persoon2
            };

            foreach (IPersoon persoon in personen)
            {
                Console.WriteLine(persoon.PrintMe());
            }
        }
    }
}
