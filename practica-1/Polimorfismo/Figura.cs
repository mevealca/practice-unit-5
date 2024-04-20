using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public abstract class Figura
    {
        public abstract double CalcularArea();
    }

    public class Rectangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Rectangulo (double baseObjeto, double altura)
        {
            Base = baseObjeto;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return Base *Altura;
        }
    }

    public class Circulo : Figura
    {
        public double Radio { get; set; }

        public Circulo (double radio)
        {
            Radio = radio;
        }

        public override double CalcularArea()
        {
           return Math.PI * Math.Pow(Radio,2);
        }
    }

    public class Triangulo : Figura
    {
        public double Altura { get; set; }
        public double Base { get; set; }

        public Triangulo(double baseObjeto, double altura) { 
        
            Base = baseObjeto;
            Altura = altura;
        
        }

        public override double CalcularArea()
        {
           
            return (Base *Altura)/2;
           
        }
    }
}
