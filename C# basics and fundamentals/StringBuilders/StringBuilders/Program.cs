﻿using System;
using System.Text;

namespace CsharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilders("Hello world");

            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            builder.Replace('-', '+');

            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));

            Console.WriteLine(builder);
        }
    }
}
