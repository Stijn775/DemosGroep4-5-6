namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(200);
            while (true)
            {
                Console.WriteLine("Welk bedrag wil je opnemen?");
                string? bedrag = Console.ReadLine();

                try
                {
                    bankAccount.NeemGeldOp(bedrag);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number");
                }
                catch (NietGenoegGeldException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine($"Huidig Budget: {bankAccount.Budget}");
                }
            }

        }
    }
}
