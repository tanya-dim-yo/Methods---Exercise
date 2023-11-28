namespace _03.Characters_In_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            if (firstChar > secondChar)
            {
                char temp = firstChar;
                firstChar = secondChar;
                secondChar = temp;
            }

            PrintCharactersRange(firstChar, secondChar);

        }

        private static void PrintCharactersRange(char a, char b)
        {
            for (int i = a + 1; i < b; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}