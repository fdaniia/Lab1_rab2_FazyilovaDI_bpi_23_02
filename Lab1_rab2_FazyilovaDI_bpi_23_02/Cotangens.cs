using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_rab2_FazyilovaDI_bpi_23_02
{
    public class Cotangens : BaseClass
    {
        public Cotangens() 
        {
            Console.WriteLine("конструктор Cotangens вызван");
        }
        public  double Calculate(double x, bool isRadians) //перегрузка метода 
        {
            if (!isRadians)
            {
                x = x * Math.PI / 180;
            }
            if (Math.Abs(Math.Sin(x)) < 1e-10) throw new ArgumentException("нельзя посчитать котангенс");
            return Math.Cos(x) / Math.Sin(x);
        }
        public override double Calculate(double x)
        {
            if (Math.Abs(Math.Sin(x)) < 1e-10) throw new ArgumentException("нельзя посчитать котангенс");
            return Math.Cos(x) / Math.Sin(x);
        }
        public override BaseClass GetDerivative() //переопределение виртуального метода
        {
            Console.WriteLine("производная -cosec²(x)");
            return new CosecansDerivative();
        }
    }
    public class CosecansDerivative : BaseClass //производная
    {
        public override double Calculate(double x)
        {
            if (Math.Abs(Math.Sin(x)) < 1e-10) throw new ArgumentException("нельзя посчитать производную котангенса");
            return -1 / (Math.Sin(x) * Math.Sin(x));
        }
    }
}