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

        private double _tau;
        public double Tau
        {
            get => _tau;
            set
            {
                _tau = value;
            }
        }

        private int _n;
        public int N
        {
            get => _n;
            set
            {
                _n = value;
            }
        }

        public EulerMethod(double a, double b, int n, double tau)
        {
            t0 = a;
            T = b;
            N = n;
            Tau = tau;

            func function = new func(Function);
            Console.WriteLine("Result : {0}", EulerMethodRealisation(function, a, b, n, tau));
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

        public static double EulerMethodRealisation(func f, double a, double b, int n, double tau)
        {
            double step = tau / n;
            double result = a;
            int m = Convert.ToInt32(Math.Ceiling(b / tau));
            double start = a, end = a + tau;

            double[,] x = new double[m + 1, n + 1];
            double[] fi = new double[m + 1];

            fi[0] = StartValue(start);

            for (int i = 0; i < m; i++)
            {
                int k = 0;
                x[i, 0] = fi[i];

                for (double j = start; j < end; j += step)
                {
                    x[i + 1, k++] = x[i, k] + step * f(fi[i]);
                    Console.Write("{0}, ", x[i + 1, k-1]);
                }

                Console.WriteLine();
                fi[i + 1] = x[i + 1, n - 1];
                start += tau;
                end += tau;
            }

            return fi[m];
        }
    }
}
