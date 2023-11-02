namespace LINQPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int amountOfNumbers = 50;
            for (int i = 0; i < amountOfNumbers; i++)
            {
                Random random = new Random();
                numbers.Add(random.Next(1,100));
            }
            Console.WriteLine("Original List: ");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            var evenNumbers = 
                from number in numbers
                where number%2 == 0
                orderby number
                select number;
            Console.WriteLine();
            Console.WriteLine("Evens");
            foreach (int number in evenNumbers.Distinct())
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            var oddNumbers =
                from number in numbers
                where number % 2 != 0
                orderby number
                select number;
            Console.WriteLine();
            Console.WriteLine("Odds");
            foreach( int number in oddNumbers.Distinct())
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
            Console.WriteLine("Original List: ");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
    }
}