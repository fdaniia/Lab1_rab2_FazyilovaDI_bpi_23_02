using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_rab2_FazyilovaDI_bpi_23_02
{
    public class Secans : BaseClass
    {
        public override double Calculate(double x)
        {
            if (Math.Abs(Math.Cos(x)) < 1e-10) throw new ArgumentException("нельзя посчитать секанс");
            return 1 / Math.Cos(x);
        }
    }
}
