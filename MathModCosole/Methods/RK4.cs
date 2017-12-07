using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathModCosole.Methods 
{
    public class RK4 : IMethod
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
        public double T { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Tau { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int N { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double Function(double t)
        {
            throw new NotImplementedException();
        }
    }
}
