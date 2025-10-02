using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_rab2_FazyilovaDI_bpi_23_02
{
    public abstract class BaseClass : IFunction //базовый родительский класс
    {
        private double x; 
        public double X 
        { 
            get { return x; } 
            set { x = value; } 
        }
        public BaseClass(double x)
        {
            Console.WriteLine("Конструктор BaseClass вызван");
            X = x;
        }      

        public virtual double Calculate(double x)
        {
            return x;
        }  
        public virtual IFunction GetDerivative(double x) //виртуальный метод для получения производной 
        {
            return null;
        }
        public virtual string GetFunctionName(double x) //виртуальный метод, который будет переопределяться в одном наследнике
        {
            return "Базовая функция";
        }
    }
}
