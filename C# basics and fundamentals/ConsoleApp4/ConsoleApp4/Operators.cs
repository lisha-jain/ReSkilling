using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 20;
            var c = 30;
            Console.WriteLine(a + b);
            Console.WriteLine((float)a + (float)b);
            Console.WriteLine(a + b * c);
            Console.WriteLine(a > b);
            Console.WriteLine(!(a != b));
        }
    }
}
