using System.Linq.Expressions;

namespace ExceptionsExample
{
    internal class Program
    {
        #region Fields

        private static List<int> numbers;

        #endregion Fields

        #region Private Methods

        private static void Main(string[] args)
        {
            // NullRefException();

            try
            {
                DivideByZero();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ik word hier opgevangen");
            }

            Person person = new Person();
            try
            {
                person.Age = -2;
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void DivideByZero()
        {
            int getal1 = 10;
            int getal2 = 0;

            try
            {
                int resultaat = getal1 / getal2;
                Console.WriteLine("Ik word alleen uitgevoerd als er geen exception is.");
            }
            catch (NullReferenceException ex) when (ex.Message.Contains("zero"))
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.HelpLink);
                Console.WriteLine("Error: Je deelt door 0");
            }
            finally
            {
                Console.WriteLine("Ik word altijd uitgevoerd!");
            }
        }

        private static void NullRefException()
        {
            numbers.Add(10);
        }

        #endregion Private Methods
    }
}