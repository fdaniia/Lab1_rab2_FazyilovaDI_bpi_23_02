using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_rab2_FazyilovaDI_bpi_23_02
{
    public abstract class BaseClass //базовый родительский класс
    {
        public BaseClass()
        {
            Console.WriteLine("Конструктор BaseClass вызван");
        }

        public virtual double Calculate(double x)
        {
            return x;
        }        
        public virtual BaseClass GetDerivative() //виртуальный метод для получения производной 
        {
            return null;
        }
        public virtual string GetFunctionName() //виртуальный метод, который будет переопределяться в одном наследнике
        {
            return "Базовая функция";
        }
    }
}
