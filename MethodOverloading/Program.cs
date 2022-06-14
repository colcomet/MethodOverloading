using System;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(13, 43));
            Console.WriteLine(Add(42.3M, 26M));
            Console.WriteLine(Add(2.34M, 56.45M));
            Console.WriteLine(Add(23, 92, true));
            Console.WriteLine(Add(1, 0, true));
            Console.WriteLine(Add(2, 56, false));

        }

        public static string Add(int addend1, int addend2)
        {
            return (addend1 + addend2).ToString();
        }
        public static string Add(decimal addend1, decimal addend2)
        {
            return (addend1 + addend2).ToString();
        }
        public static string Add(int addend1, int addend2, bool inDollars)
        {
            if (inDollars)
            {
                int total = addend1 + addend2;
                return (total == 1) ? $"{total} dollar" : $"{total} dollars";
            }
            return (addend1 + addend2).ToString();
        }

    }
}
