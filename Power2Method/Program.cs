using System;

namespace Power2Method
{
    class Program
    {
        /// <summary>
        /// reads a string given by user
        /// convert the string into a int
        /// call PowersOf2Until5 method
        /// </summary>
        /// <param name="args"></param> args passed by user
        static void Main(string[] args)
        {
            /*string aux = Console.ReadLine();
            int n = Convert.ToInt32(aux);*/
            PowersOf2UntilN(2, 5);
            PowersOf2Until5();
        }
        /// <summary>
        /// call PowerOf2UntilN, given it a int
        /// </summary>
        private static void PowersOf2Until5()
        {
            PowersOf2UntilN(2);
        }
        /// <summary>
        /// prints i unit i reachs the max value defined by user
        /// </summary>
        /// <param name="n"></param> int given by user
        private static void PowersOf2UntilN(int n)
        {
            for (int i = 1; i <= (i << n); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
        private static void PowersOf2UntilN(int n1, int n2)
        {
            for (int i = 1; i >= (i << n1) && i <= (i << n2); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
