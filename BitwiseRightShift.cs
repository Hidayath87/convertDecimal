﻿using System;

namespace Operator
{
    class RightShift
    {
        public static void Main(string[] args)
        {
            int number = 42;

            Console.WriteLine("{0}>>1 = {1}", number, number >> 1);
            Console.WriteLine("{0}>>2 = {1}", number, number >> 2);
            Console.WriteLine("{0}>>4 = {1}", number, number >> 4);
        }
    }
}
