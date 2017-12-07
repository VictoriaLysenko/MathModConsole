using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathModCosole.Methods
{
    class Method4 : IMethod
    {
        public double t0 { get; set; }
        public double T { get; set; }
        public double Tau { get; set; }
        public int N { get; set; }

        public Method4(double a, double b, int n, double tau)
        {
            t0 = a;
            T = b;
            N = n;
            Tau = tau;

            func function = new func(Function);
            Console.WriteLine("Result : {0}", MyMethod(function, a, b, n, tau));
        }

        public delegate double func(double t);
        public double Function(double t)
        {
            return 6 * (t - 1);
        }

        public static double StartValue(double t)
        {
            return t;
        }

        public static double MyMethod(func f, double a, double b, int n, double tau)
        {
            return 2.5;
        }
    }
}
