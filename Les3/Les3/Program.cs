namespace Les3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CallbackMethode cm = new CallbackMethode();
            cm.LoadData(PrintInt);
            string s = Console.ReadLine();
        }

        static void PrintLijst(List<int> lijst)
        {
            foreach (int item in lijst)
            {
                Console.WriteLine(item);
            }
        }

        static void PrintInt(int number)
        {
            Console.WriteLine(number);
        }
    }
}
