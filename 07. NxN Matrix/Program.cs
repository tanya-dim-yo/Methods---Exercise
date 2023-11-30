namespace _07.NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintMatrix(n);
        }

        private static void PrintMatrix(int n)
        {
            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= n; cols++)
                {
                    Console.Write(n + " ");
                }

                Console.WriteLine();
            }
        }
    }
}