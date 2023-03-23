using System;

namespace Lucas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a int");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Lucas de {n} = {Lucas(n)}");
        }
        private static int Lucas(int n)
        {
            if (n == 0) return 2;
            if (n == 1) return 1;
            return Lucas(n - 1) + Lucas(n - 2);
        }
    }
}
