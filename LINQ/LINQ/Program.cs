namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(numbers.Average());
            List<int> numbersHogerDan5 = numbers.Where(number => number>5).ToList();

            foreach (int number in numbersHogerDan5)
            {
                Console.Write($"{number} ");
            }

            List<Student> students = new List<Student>()
            {
                new Student("Jef", 10),
                new Student("Jaak", 12),
                new Student("Stef", 18),
                new Student("Marie", 8),
                new Student("Bert", 17),
            };


            List<string> studentNamem = students.Select(s => s.Name);

            double gemiddeldeScore = students.Average(student => student.Score);


            Console.WriteLine(
               gemiddeldeScore
            );
        }

        private static bool IsHogerDan5(int number)
        {
            return number > 5;
        }
    }
}
