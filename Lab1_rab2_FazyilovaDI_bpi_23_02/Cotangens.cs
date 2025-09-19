using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_rab2_FazyilovaDI_bpi_23_02
{
    public  class Cotangens : BaseClass
    {
        public override double Calculate(double x)
        {
            if (Math.Abs(Math.Sin(x)) < 1e-10) throw new ArgumentException("нельзя посчитать котангенс");
            return Math.Cos(x) / Math.Sin(x) ;
        }
    }
}
