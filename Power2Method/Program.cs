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
            string aux = Console.ReadLine();
            int n = Convert.ToInt32(aux);
            PowersOf2Until5();
        }
        /// <summary>
        /// call PowerOf2UntilN till i reachs 32
        /// </summary>
        private static void PowersOf2Until5()
        {
            for (int i = 1; i <= 32; i = i << 1)
            {
                PowersOf2UntilN();
            }
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
    }
}
