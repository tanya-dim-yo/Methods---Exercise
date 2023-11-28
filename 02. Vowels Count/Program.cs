namespace _02.Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            VowelsCount(input);
        }

        private static void VowelsCount(string text)
        {
            int count = 0;

            foreach (var character in text)
            {
                if (IsVowel(character))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        private static bool IsVowel(char character)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y', };
            return vowels.Contains(character);
        }
    }
}