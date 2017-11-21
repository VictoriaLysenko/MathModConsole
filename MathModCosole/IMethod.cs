using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathModCosole
{
    public interface IMethod
    {
        Double t0
        {
            get;
            set;
        }

        Double T
        {
            get;
            set;
        }

        double StartValue(double t);

        double Function(double t);
    }
}
