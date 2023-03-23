using System;

namespace Power2Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux = Console.Readline();
            int n = Convert.ToInt32(aux);

            PowersOf2UntilN(2);//Method call
            PowersOf2UntilN(5);//Method call
        }
        private static void PowersOf2Until5()
        {
            for (int i = 1; i <= (i << 5); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
        private static void PowersOf2UntilN(int n)
        {
            for (int i = 1; i <= (i << n); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
