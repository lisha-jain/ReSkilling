using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            byte b = (byte)i;
            var number = " 1234";
            int j = Convert.ToInt32(number);
            string str = "true";
            bool b1 = Convert.ToBoolean(str);
            Console.WriteLine(b1);
            Console.WriteLine(j);
            Console.WriteLine(b);
        }
    }
}
