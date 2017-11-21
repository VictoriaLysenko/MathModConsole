using MathModCosole.Methods;
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
            EulerMethod euler = new EulerMethod(1, 2, 0.5);

            Console.ReadLine();
        }
    }
}
