namespace _04.Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isValid = true;

            if (!IsLengthValid(password))
            {
                isValid= false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!OnlyContainsLettersAndDigits(password))
            {
                isValid= false;
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!ContainsAtLeastTwoDigits(password))
            {
                isValid= false;
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool ContainsAtLeastTwoDigits(string password)
        {
            return password.Count(char.IsDigit) >= 2;
        }

        private static bool OnlyContainsLettersAndDigits(string password)
        {
            return password.All(char.IsLetterOrDigit);
        }

        private static bool IsLengthValid(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
    }
}