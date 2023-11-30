namespace _06.Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleCharacter(input);
        }

        private static void PrintMiddleCharacter(string input)
        {
            if (input.Length % 2 == 0)
            {
                Console.WriteLine($"{input[(input.Length / 2) - 1]}{input[input.Length / 2]}");
            }
            else
            {
                Console.WriteLine($"{input[input.Length / 2]}");
            }
        }
    }
}