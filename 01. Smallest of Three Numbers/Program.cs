namespace _01.Smallest_Of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            SmallestNumber(firstNumber, secondNumber, thirdNumber);
        }

        private static void SmallestNumber(int a, int b, int c)
        {
            if (a <= b && a <= c)
            {
                Console.WriteLine(a);
            }
            else if (b <= a && b <= c)
            {
                Console.WriteLine(b);
            }
            else if (c <= a && c <= b)
            {
                Console.WriteLine(c);
            }
        }
    }
}