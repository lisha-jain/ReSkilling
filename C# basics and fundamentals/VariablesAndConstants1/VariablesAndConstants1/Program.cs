﻿using System;

namespace UsingConst
{
    class Program
    {
        const int a = 10;

        static void Main(string[] args)
        {
            const int b = 20;
            const int c = b + a;
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}