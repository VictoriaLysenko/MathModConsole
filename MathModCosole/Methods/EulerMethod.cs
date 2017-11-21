using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathModCosole.Methods
{
    public class EulerMethod : IMethod
    {
        private double _t0;
        public double t0
        {
            get => _t0;
            set
            {
                _t0 = value;
            }
        }

        private double _T;
        public double T
        {
            get => _T;
            set
            {
                _T = value;
            }
        }

        public EulerMethod(double a, double b, double h)
        {
            t0 = a;
            T = b;

            func function = new func(Function);
            Console.WriteLine("Result : {0}", EulerMethodRealisation(function, a, b, h));
        }

        public delegate double func(double t);

        public double Function(double t)
        {
            return 6 * (t - 1);
        }

        public double StartValue(double t)
        {
            return t;
        }

        public static double EulerMethodRealisation(func f, double a, double b, double step)
        {
            double result = a;

            for (double x = a; x <= b; x += step)
            {
                Console.WriteLine("\t" + x + "\t" + result);
                result += step * f(result);
            }

            return result;
        }
    }
}
