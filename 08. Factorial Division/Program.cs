namespace _08.Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", (double)Factorial(firstNumber) / Factorial(secondNumber));
        }

        private static long Factorial(int a)
        {
            long factorial = 1;

            for (int i = 1; i <= a; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}