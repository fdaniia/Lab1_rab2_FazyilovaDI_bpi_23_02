using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_rab2_FazyilovaDI_bpi_23_02
{
    public abstract class BaseClass //базовый родительский класс
    {
        public virtual double Calculate(double x)
        {
            return x;
        }
    }
}
