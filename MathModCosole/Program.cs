﻿using MathModCosole.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathModCosole
{
    class Program
    {
        static void Main(string[] args)
        {
            EulerMethod euler = new EulerMethod(1, 3, 10, 1);

           // Method4 method4 = new Method4(1, 3, 10, 1);

            Console.ReadLine();
        }
    }
}
