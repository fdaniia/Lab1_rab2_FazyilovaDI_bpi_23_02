using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_rab2_FazyilovaDI_bpi_23_02
{
    public interface IFunction //интерфейс
    {
        double Calculate(double x);
        string GetFunctionName(double x);
        IFunction GetDerivative(double x);
    }
}
