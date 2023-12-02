namespace _11.Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split();
                string cmdType = cmdArgs[0];

                if (cmdType == "exchange")
                {
                    int index = int.Parse(cmdArgs[1]);

                    if (index < 0 || index >= arr.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    arr = ExchangeArray(arr, index);
                }
                else if (cmdType == "max")
                {
                    string evenOrOddArg = cmdArgs[1];
                    IndexOfMaxEvenOrOddElement(arr, evenOrOddArg);
                }
            }
        }

        private static int IndexOfMaxEvenOrOddElement(int[] arr, string evenOrOddArg)
        {
            int maxIndex = -1;
            int currMax = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                int currNum = arr[i];

                if (currNum >= currMax)
                {
                    currMax = currNum;
                }
            }
        }

        private static int[] ExchangeArray(int[] originalArr, int index)
        {
            int[] modifiedArr = new int[originalArr.Length];
            int modifiedArrayIndex = 0;

            for (int i = index + 1; i < originalArr.Length; i++)
            {
                modifiedArr[modifiedArrayIndex++] = originalArr[i];
            }

            for (int i = 0; i <= index; i++)
            {
                modifiedArr[modifiedArrayIndex++] = originalArr[i];
            }

            return modifiedArr;
        }
    }
}