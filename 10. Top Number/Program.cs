namespace _10.Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endNumber; i++)
            {
                bool isTopInteger = true;

                if (!SumDigitsDivisibleByEight(i))
                {
                    isTopInteger = false;
                }

                if (!AtLeastOneOddDigit(i))
                {
                    isTopInteger = false;
                }

                if (isTopInteger)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool AtLeastOneOddDigit(int a)
        {
            string number = Convert.ToString(a);
            bool result = true;
            int counter = 0;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 != 0)
                {
                    counter++;
                }
            }

            if (counter < 1)
            {
                result = false;
            }

            return result;

        }

        private static bool SumDigitsDivisibleByEight(int a)
        {
            string number = Convert.ToString(a);
            int sum = 0;
            bool result = true;

            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }

            if (sum % 8 != 0)
            {
                result = false;
            }

            return result;
        }
    }
}