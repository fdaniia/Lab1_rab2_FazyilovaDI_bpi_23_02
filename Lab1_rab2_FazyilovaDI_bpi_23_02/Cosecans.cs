using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_rab2_FazyilovaDI_bpi_23_02
{
    public class Cosecans : BaseClass
    {
        public Cosecans() : base() 
        {
            Console.WriteLine("конструктор Cosecans вызван");
        }
        public override double Calculate(double x)
        {
            if (Math.Abs(Math.Sin(x)) < 1e-10) throw new ArgumentException("нельзя посчитать косеканс");
            return 1 / Math.Sin(x);
        }
        public override BaseClass GetDerivative()
        {
            Console.WriteLine("производная -cosec(x)*ctg(x)");
            return new CosecansDerivative();
        }        
        public override string GetFunctionName() //переопределяем виртуальный метод
        {
            return "производная cosec(x)";
        }
    }
}