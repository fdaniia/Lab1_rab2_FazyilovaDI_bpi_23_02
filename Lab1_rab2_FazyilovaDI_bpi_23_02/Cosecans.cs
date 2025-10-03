using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_rab2_FazyilovaDI_bpi_23_02
{
    public class Cosecans : BaseClass
    {
        
        public Cosecans(double x) : base (x)
        {
            Console.WriteLine("конструктор Cosecans вызван");
        }
        public override double Calculate(double x)
        {
            if (Math.Abs(Math.Sin(x)) < 1e-10) throw new ArgumentException("нельзя посчитать косеканс");
            return 1 / Math.Sin(x);
        }
        public override double GetDerivative(double x) //производная
        {
            if (Math.Abs(Math.Sin(x)) < 1e-10) throw new ArgumentException("нельзя посчитать производную");
            return -(1 / Math.Sin(x)) * (Math.Cos(x) / Math.Sin(x));
            /*Console.WriteLine("производная -cosec(x)*ctg(x)");
            return new CosecansDerivative(x); */
        }        
        public override string GetFunctionName(double x) //переопределяем виртуальный метод
        {
            return "производная cosec(x)";
        }
    }
}