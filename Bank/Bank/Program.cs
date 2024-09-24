namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(200);
            Console.WriteLine("Welk bedrag wil je opnemen?");
            string bedrag = Console.ReadLine();


        }
    }
}
