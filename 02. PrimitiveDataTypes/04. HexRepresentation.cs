﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexRepresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 254;
            Console.WriteLine("{0:X}", num);
            decimal number = 0xFE;
            Console.WriteLine(0xFE);
            Console.WriteLine(num == number);
        }
    }
}
