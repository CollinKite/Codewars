namespace Even_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static string EvenOrOdd(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }

    }
}