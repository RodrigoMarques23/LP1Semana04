using System;

namespace Power2Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux = Console.ReadLine();
            int n = Convert.ToInt32(aux);


            PowersOf2UntilN(2);//Method call
            PowersOf2UntilN(5);//Method call
        }
        private static void PowersOf2Until5()
        {
            for (int i = 1; i <= 32; i = i << 1)
            {
                PowersOf2UntilN();
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
