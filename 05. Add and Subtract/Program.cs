namespace _05.Add_And_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = SubtractCalculation(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(result);
        }

        private static int SubtractCalculation(int a, int b, int c)
        {
            return AddCalculation(a, b) - c;
        }

        private static int AddCalculation(int a, int b)
        {
            return a + b;
        }
    }
}